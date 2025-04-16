using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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

      
        public ViewResult Index()
        {
           
            var employee = new { name = "kumar", ag = 30, address = "Blr" };
            ViewBag.Employee = employee;
           
            return View(employee);
        }
        
        [ActionName("Homepage")]
        public ViewResult Contact()
        {
            var name = ViewData["Name"];
            string msg = ViewBag.msg;
            TempData.Keep();
            var message = TempData["CityName"];
            TempData.Keep("SuccessMessage");
            TempData.Remove("");
            return View("Contact");
        }

       [NonAction]
        public ViewResult UserDetails()
        {

            return View() ;
        }
        [HttpGet]
        public ViewResult About()
        {
           
            return View(TempEmployee);
        }

        [HttpPost]
        public ViewResult postaction()
        {

            return View("Index");
        }
        [HttpGet]
        public ViewResult DisplyEmployee()
        {
            List<Employee> emplist = TempEmployee;
            
            return View(emplist);
        }
        [HttpPost]
        public ActionResult postEmployee(FormCollection form)
        {
            Employee empobj = new Employee();
            empobj.Id = Convert.ToInt32(form["Id"]);
            empobj.Name = form["Name"];
            empobj.Salary =Convert.ToDecimal(form["Salary"]);
            empobj.Department = form["Department"];
            TempEmployee.Add(empobj);
            return View("DisplyEmployee", TempEmployee);
        }
        [HttpGet]
        public ActionResult postEmployee2()
        {
            return View();
        }


        [HttpPost]
        public ActionResult postEmployee2(Employee emp)
        {
           
            TempEmployee.Add(emp);
            return View("DisplyEmployee", TempEmployee);
        }



    }

}