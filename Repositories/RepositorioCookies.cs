using System;
using System.Web;

namespace RestauranteOnline.Repositories
{
    public class RepositorioCookies
    {
        public static void RegistraCookies(long IDUsuario)
        {
            HttpCookie UserCookie = new HttpCookie("CookieUsuario");
            UserCookie.Values["IDUsuario"] = IDUsuario.ToString();
            UserCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(UserCookie);

        }


    }
}