using RestauranteOnline.Repositórios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Filters
{
    public class FiltroAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtroContexto)
        {
            var controller = filtroContexto.ActionDescriptor.ControllerDescriptor.ControllerName;
            var action = filtroContexto.ActionDescriptor.ActionName;

            if (controller != "Home" || action != "Login")
            {
                if (GestaoUsuarios.VerificaStatusUsusario() == null)
                {
                    filtroContexto.RequestContext.HttpContext.Response.Redirect("/Home/Login");
                }
            }
        }
    }
}