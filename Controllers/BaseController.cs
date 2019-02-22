﻿using RestauranteOnline.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    [FiltroAcesso]
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filtroContexto)
        {
            base.OnActionExecuting(filtroContexto);

        }


    }
}
