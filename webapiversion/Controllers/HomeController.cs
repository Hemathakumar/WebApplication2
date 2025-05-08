using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapiversion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            Session["UserName"] = "Kumar";
            var name = Session["UserName"] as string;

            HttpCookie cookie = new HttpCookie("EmilId");
            cookie.Value = "Hemantha@gmail.com";
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);
            return View();
        }
        public ActionResult Index2()
        {
            
            var name = Session["UserName"] as string;

            return View("Index");
        }
        public ActionResult Index3()
        {
            var name = Session["UserName"] as string;
            Session.Clear();
            if (name == null)
            {
                return View("Index2");
            }

            return View("Index");
           
            //Session.Abandon();
        }

    }
}
