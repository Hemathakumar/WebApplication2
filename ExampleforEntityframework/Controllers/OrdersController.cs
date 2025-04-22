using ExampleforEntityframework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace ExampleforEntityframework.Controllers
{
    public class OrdersController : Controller
    {

        private EmployeeDBContext db = new EmployeeDBContext();
        // GET: Orders
       
        public ActionResult Index()
        {
            string[] names = { "John", "Jane", "Tom", "Kunal" };

            foreach(var name in names)
            {
                if (name.Length <= 4)
                {
                    Console.WriteLine(name);
                }
            }

            var result = names.Where(n => n.Length <= 4).FirstOrDefault();
            var result2 = names.Where(n => n.Length <= 4).SingleOrDefault();





          

            IQueryable<Employee> querayablelist = db.employees;
            List<Employee> listemp = db.employees.ToList();
            IEnumerable<Employee> listemp2 = db.employees.ToList();

            var result3 = querayablelist.Where(p => p.Name.StartsWith("H")).ToList();


            IEnumerable<Employee> list = querayablelist;


            return View();



        }

        // GET: Orders/Details/5
        public ActionResult Details(int id,string name)
        {
            var res = db.employees.Where(e => e.Id == id).SingleOrDefault();
            var res2 = db.employees.Where(e => e.Name == name).ToList();

            var deptrecords = from p in db.employees
                              join pr in db.products on p.Id equals pr.Id
                              select new
                              {
                                  p.Department,
                                  pr.ProductName
                              };

                              //.Where(p => p.Department.Contains("HR"))
                              //select new
                              //{
                              //    p.Name,
                              //    p.Department

                              //};



            return View();
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Orders/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orders/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
