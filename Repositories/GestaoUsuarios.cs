using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RestauranteOnline.Repositórios
{
    public class GestaoUsuarios
    {

        public static Usuario RecuperarUsusario(long IDUsuario)
        {

            try
            {
                RestauranteBDEntities db = new RestauranteBDEntities();
                var usuario = db.Usuario.Where(u => u.IDUsuario == IDUsuario).SingleOrDefault();
                return usuario;

            }
            catch (Exception)
            {
                return null;
            }

        }

        public static Usuario VerificaStatusUsusario()
        {


            var usuario = HttpContext.Current.Request.Cookies["CookieUsuario"];
            if (usuario == null)
                return null;

            else
            {
                long IDUsuario = Convert.ToInt64(usuario.Values["IDUsuario"]);
                var usuarioRetornado = RecuperarUsusario(IDUsuario);
                return usuarioRetornado;
            }


        }




        public static bool VerificarUsuarioBD(string login, string senha)
        {
            try
            {
                RestauranteBDEntities db = new RestauranteBDEntities();
                var usuario =
                    db.Usuario.Where(x => x.Login == login && x.Senha == senha).SingleOrDefault();
                if (usuario == null)
                {
                    return false;
                }
                else
                {
                    GestaoCookies.CriarCookie(usuario.IDUsuario);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}