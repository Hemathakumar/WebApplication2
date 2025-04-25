using JavaScriptexamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScriptexamples.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> TempEmployee = new List<Employee>();

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Salary = 75000 },
            new Employee { Id = 3, Name = "Carol White", Department = "Finance", Salary = 68000 },
            new Employee { Id = 4, Name = "David Brown", Department = "Marketing", Salary = 62000 },
            new Employee { Id = 5, Name = "Eva Green", Department = "IT", Salary = 80000 }
        };
        }


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
        public ActionResult Getemployees()
        {
            ViewBag.Message = "Your contact page.";
            TempEmployee=  GetEmployees();
            return View(TempEmployee);
        }

        public ActionResult Hello()
        {
            return Json("Hello MVC",JsonRequestBehavior.AllowGet);
        }
    }
}