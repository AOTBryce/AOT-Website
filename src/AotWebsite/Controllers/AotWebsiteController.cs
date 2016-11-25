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

            ViewBag.CompanyName = "AOT";
            ViewBag.StartYear = 2016;
            ViewBag.Description = "<p><u>Nothing in this world thats worth having comes easy</u></p>";
            ViewBag.Developers = new string[]
            {
                "HTML: HTML5Up",
                "ASP.Net Developer: AOTBryce",
                "Graphics: TBD",
                "Hosting: AWS"
                
                //"Project 1: 2016",
                //"Project 2: 2017",
                //"Project 3: 2017",
                //"Project 4: 2018"
            };
            //below value to be swapped in for projects in order to demonstrate usefulness of if statement
            var projects2 = new string[] { };

            return View();

        }

    }
}