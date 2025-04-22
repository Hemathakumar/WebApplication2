using DBfirstexample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBfirstexample.Controllers
{

    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            

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
        public ActionResult GetEmployees()
        {
           
            DemoEntityEntities dbentity = new DemoEntityEntities();
            var result = dbentity.Employees.ToList(); //return all records
            //Employee emp = new Employee();
            //Employee emp2 = dbentity.Employees.Find(1);
            //Employee emp2 = dbentity.Employees.Where(e=>e.Name.StartsWith("H")).SingleOrDefault(); //
            //Employee emp2 = dbentity.Employees.Where(e=>e.Name.StartsWith("H")).First();

            //Employee emp4 = dbentity.Employees.Remove(emp);
            //Employee emp3 = dbentity.Employees.Add(emp);
           
            dbentity.SaveChanges();
            return View(result);
        }
    }
}