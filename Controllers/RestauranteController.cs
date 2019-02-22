using RestauranteOnline.Models;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class RestauranteController : BaseController
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        // GET: /Restaurante/

        public ActionResult Index()
        {
            var restaurante = db.Restaurante.Include("Bairro").Include("Genero").ToList();
            return View(restaurante);
        }

        public ActionResult Inserir()
        {
            ViewBag.Bairro = db.Bairro.ToList();
            ViewBag.Genero = db.Genero.ToList();
            var model = new RestauranteMetadado();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(RestauranteMetadado model)
        {
            //var imageTypes = new string[]{
            //        "image/gif",
            //        "image/jpeg",
            //        "image/pjpeg",
            //        "image/png"
            //    };
            //if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
            //{
            //    ModelState.AddModelError("ImageUpload", "Este campo é obrigatório");
            //}
            //else if (!imageTypes.Contains(model.ImageUpload.ContentType))
            //{
            //    ModelState.AddModelError("ImageUpload", "Escolha uma iamgem GIF, JPG ou PNG.");
            //}
            if (ModelState.IsValid)
            {
                var restaurante = new Restaurante();
                restaurante.IDBairro = model.IDBairro;
                restaurante.IDGenero = model.IDGenero;
                restaurante.Nome = model.Nome;
                restaurante.Endereco = model.Endereco;
                restaurante.Telefone = model.Telefone;
                restaurante.Site = model.Site;
                restaurante.DisqueEntrega = model.DisqueEntrega;
                ////lemos a imagem e a seguir os bytes armazenados
                //using (var binaryReader = new BinaryReader(model.ImageUpload.InputStream))
                //    restaurante.Foto = binaryReader.ReadBytes(model.ImageUpload.ContentLength);
                db.Restaurante.Add(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                // Se ocorrer um erro retorna para pagina
                ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome");
                ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao");
                return View(model);
            }
        }


        public ActionResult Alterar(long id)
        {
            Restaurante restaurante = db.Restaurante.Find(id);
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante.IDBairro);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante.IDGenero);
            return View(restaurante);
        }

        [HttpPost]
        public ActionResult Alterar(RestauranteMetadado restaurante)
        {
            return View();
        }

        // metodo excluir

        public ActionResult Excluir(long id)
        {
            Restaurante restaurante = db.Restaurante.Find(id);
            return View(restaurante);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(long id)
        {

            try
            {
                Restaurante restaurante = db.Restaurante.Find(id);
                db.Restaurante.Remove(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return RedirectToAction("Erro ao Excluir");


            }

        }

        public ActionResult ErroExcluir()
        {

            return View();
        }

    }
}
