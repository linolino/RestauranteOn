using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class GeneroController : BaseController
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        // GET: /Restaurante/

        public ActionResult Index()
        {

            return View(db.Genero.ToList());
        }
        /// <summary>
        /// ///////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Genero.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(genero);
        }
        //////////////////////////////////////////////////////////////
        public ActionResult Alterar(long id)
        {
            Genero genero = db.Genero.Find(id);

            return View(genero);
        }

        [HttpPost]
        public ActionResult Alterar(Genero genero)
        {
            if (ModelState.IsValid)
            {

                db.Entry(genero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }


            return View(genero);
        }

        //// metodo excluir

        public ActionResult Excluir(long id)
        {
            Genero genero = db.Genero.Find(id);
            return View(genero);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(long id)
        {

            try
            {
                Genero genero = db.Genero.Find(id);
                db.Genero.Remove(genero);
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
