using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class BairroController : BaseController
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        // GET: /Restaurante/

        public ActionResult Index()
        {
          
            return View(db.Bairro.ToList());
        }

        public ActionResult Inserir()
        {
                return View();
        }

        [HttpPost]
        public ActionResult Inserir(Bairro bairro)
        {
           if (ModelState.IsValid)
           {
               db.Bairro.Add(bairro);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(bairro);
        }


        public ActionResult Alterar(long id)
        {
            Bairro bairro = db.Bairro.Find(id);
           
            return View(bairro);
        }

        [HttpPost]
        public ActionResult Alterar(Bairro bairro)
        {
            if (ModelState.IsValid)
            {
               
                db.Entry(bairro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
          

            return View(bairro);
        }

        //// metodo excluir

        public ActionResult Excluir(long id)
        {
            Bairro bairro = db.Bairro.Find(id);
            return View(bairro);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(long id)
        {

            try
            {
                Bairro bairro = db.Bairro.Find(id);
                db.Bairro.Remove(bairro);
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
