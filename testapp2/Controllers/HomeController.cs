using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testapp2.Models;

namespace testapp2.Controllers
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
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20 },
            new Student { Id = 2, Name = "Bob", Age = 22 },
            new Student { Id = 3, Name = "Charlie", Age = 23 },
            new Student { Id = 4, Name = "David", Age = 21 },
            new Student { Id = 5, Name = "Eva", Age = 20 }
        };
            ViewBag.Message = "Your contact page.";

            return View(students);
        }
        [HttpGet]
        public JsonResult GetMessage()
        {
            var message = new { Text = "Hello from AJAX!", Timestamp = DateTime.Now.ToString() };
            return Json(message, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SubmitForm(string name, int age)
        {
            var result = new { Message = $"Hello, {name}! You are {age} years old." };
            return Json(result);
        }
        [HttpPost]
        public JsonResult SubmitFeedback(FeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                return Json(new { success = true, message = "Thanks, " + model.Name + "!" });
            }
            return Json(new { success = false, message = "Validation failed." });
        }



    }
}