using mvcdemotest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemotest.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();
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
        public ActionResult hello(string fname, string lname)
        {
            Response.Write("Hello " + fname + " " + lname);
            return View();

        }

        public ActionResult Register()
        {
            return View();
            ViewBag.msg = "User created sucessfully";
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                // Validation failed - show form again with validation messages

                return View(user);
            }

            // Validation passed - proceed with registration logic
            UserRepository repo = new UserRepository();
            repo.AddUser(user);
            return RedirectToAction("Register");
        }

        public ActionResult GetAllUsers()
        {
            UserRepository repo = new UserRepository();
         
            return View("UsersList",repo.GetAllUsers());
        }

        public ActionResult GetAllUsersEntity()
        {
             EmployeeContext db = new EmployeeContext();
            List<Employee> emplist = db.Employees.ToList();
            return View("UsersList", emplist);
        }
        public ActionResult CreateNewEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}