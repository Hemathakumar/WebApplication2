using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployees()
        {
            return View();
        }
        public ActionResult GetEmployee(int id)
        {
            return View();
        }
        public  ActionResult DeleteEmployee(int id)
        {
            return View();
        }
      
        
    }
}