using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AotWebsite.Controllers
{
    /*
    Every public method in a controller is an action method
         */

    public class AotWebsiteController : Controller
    {

        public ActionResult Detail()
        {
            return View();

        }

    }
}