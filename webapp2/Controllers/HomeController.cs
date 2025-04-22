using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp2.Models;

namespace webapp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            myDBEntities dbentities = new myDBEntities();
            IEnumerable<Product> list = dbentities.Products.ToList();

            var pd = list.Where(p => p.Price > 500).ToList();
            return View();
        }

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