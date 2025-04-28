using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreasMVCTest.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Employee
        public ActionResult Index()
        {
            return View();
        }
    }
}