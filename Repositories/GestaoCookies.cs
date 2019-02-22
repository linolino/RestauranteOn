using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RestauranteOnline.Repositórios
{
    public class GestaoCookies
    {

        public static bool ApagarCookie()
        {
            var usuario = HttpContext.Current.Request.Cookies["CookieUsuario"];
            if (usuario == null)
            {
                return false;
            }
            else
            {

                HttpContext.Current.Response.Cookies[usuario.Name].Expires = DateTime.Now.AddDays(-1);
                return true;

            }

        }


        public static void CriarCookie(long IDUsuario)
        {

            HttpCookie CookieUsuario = new HttpCookie("CookieUsuario");

            CookieUsuario.Values["IDUsuario"] = IDUsuario.ToString();

            CookieUsuario.Expires = DateTime.Now.AddDays(1);

            HttpContext.Current.Response.Cookies.Add(CookieUsuario);
        }
    }
}