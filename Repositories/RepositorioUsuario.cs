using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RestauranteOnline.Repositories
{
    public class RepositorioUsuario
    {
        public static bool AutenticarUsuario(string login, string senha)
        {
            try
            {
                using (RestauranteBDEntities db = new RestauranteBDEntities())
                {
                    var QueryAutenticaUsuarios =
                        db.Usuario.Where(x => x.Login == login && x.Senha==senha).SingleOrDefault();
                    if (QueryAutenticaUsuarios == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistraCookies(QueryAutenticaUsuarios.IDUsuario);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}