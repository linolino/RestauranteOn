using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteOnline.Models;


namespace RestauranteOnline.Controllers
{
    public class HomeController : Controller
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        public ActionResult Login()
        {
            ViewBag.Title = "Seja Bem Vindo ...Autenticado";
            return View();

        }


        public ActionResult Index()
        {
            ViewBag.Genero = new SelectList(db.Genero, "IDGenero", "Descricao");
            ViewBag.Bairro = new SelectList(db.Bairro, "IDBairro", "Nome");
            return View();
        }


        public ActionResult Pesquisar(Pesquisa pesquisa)
        {

            var restaurantes = from r in db.Restaurante
                               where r.IDBairro == pesquisa.IDBairro && r.IDGenero == pesquisa.IDGenero
                               select new ResultadoPesquisa
                               {
                                   Nome = r.Nome,
                                   Endereco = r.Endereco,
                                   Telefone = r.Telefone,
                                   Site = r.Site,
                                   DisqueEntrega = r.DisqueEntrega,
                               };
            return Json(restaurantes, JsonRequestBehavior.AllowGet);
        }



    }
}
