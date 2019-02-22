﻿using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class UsuarioController : BaseController
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        // GET: /Restaurante/

        public ActionResult Index()
        {

            return View(db.Usuario.ToList());
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(usuario);
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Alterar(long id)
        {
            Usuario usuario = db.Usuario.Find(id);

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }


            return View(usuario);
        }

        //// metodo excluir

        public ActionResult Excluir(long id)
        {
            Usuario usuario = db.Usuario.Find(id);
            return View(usuario);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(long id)
        {

            try
            {
                Usuario usuario = db.Usuario.Find(id);
                db.Usuario.Remove(usuario);
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
