using AotWebsite.Models;
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

            var project = new Project()
            {
                ProjectTitle = "Project1",
                YearReleased = 2016,
                DescriptionHtml = "<p><u>Cool Project</u></p>",
                //DescriptionHtml = "<p><u>Nothing in this world thats worth having comes easy</u></p>",
                Developers = new Developer[]
                {
                    new Developer() {Name = "AOTBryce", Role = "ASP.Net Developer" },
                    new Developer() {Name = "HTML5Up", Role = "HTML" },
                    new Developer() {Name = "TBD", Role = "Graphics" },
                    new Developer() {Name = "AWS", Role = "Hosting" }
                }

            };

            //can pass the new object to the view which will allow the view to be strongly typed
            return View(project);

                //"Project 1: 2016",
                //"Project 2: 2017",
                //"Project 3: 2017",
                //"Project 4: 2018"
         
            //below value to be swapped in for projects in order to demonstrate usefulness of if statement
            //var projects2 = new string[] { };

        }

    }
}