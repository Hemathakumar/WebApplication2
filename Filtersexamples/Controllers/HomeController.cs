using Filtersexamples.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtersexamples.Controllers
{
    
    public class HomeController : Controller
    {
        [CustomeException]
        public ActionResult Index()
        {
            //throw new Exception("something went wrong in index method");
            return View();

        }

        [CustomeException]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}