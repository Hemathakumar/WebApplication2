using ExampleforEntityframework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleforEntityframework;

namespace ExampleforEntityframework.Controllers
{
   
    public class HomeController : Controller
    {
        private EmployeeDBContext dBContext = new EmployeeDBContext();
       
        public ActionResult Index()
        {
            // throw new Exception("Something went wrong");
            ViewBag.Message = "Your application description page.";
            return View("Index");
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
        
        public ActionResult Emplist()
        {
            return View(dBContext.employees.ToList());
        }
        public ActionResult Details(int id)
        {
            if (id <= 0)
                return new HttpNotFoundResult();

            return View("DetailsView");
        }

        public ActionResult Details(Employee emp)
        {
           
            return View("DetailsView");
        }

    }
}