using RestauranteOnline.Repositories;
using RestauranteOnline.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace RestauranteOnline.Controllers
{

    public class AutenticacaoController : Controller
    {


        [HttpPost]
        public JsonResult DesautenticarUsuario()
        {
            if (GestaoCookies.ApagarCookie())
                return Json(new { OK = true }, JsonRequestBehavior.AllowGet);

            else
                return Json(new { OK = false }, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult VerificarAutenticacao()
        {
            if (GestaoUsuarios.VerificaStatusUsusario() != null)
            {

                return Json(new { OK = true },JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { OK = false },JsonRequestBehavior.AllowGet);

            }

        }


        public JsonResult AutenticarUsuario(string login, string senha)
        {
            if (RepositorioUsuario.AutenticarUsuario(login, senha))
            {

                return Json(new { OK = true, Mensagem = "Usuario encontrado. Redirecionando..." },
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { OK = false, Mensagem = "Usuario não encontrado." },
                    JsonRequestBehavior.AllowGet);

            }

        }

    }
}
