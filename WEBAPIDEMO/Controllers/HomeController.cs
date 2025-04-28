using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;

namespace WEBAPIDEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            string baseUrl = "http://localhost:portnumber/api/values"; // Replace with your actual URL

            // Try JSON
            string jsonUrl = baseUrl + "?format=json";
            var jsonResponse =  client.GetAsync(jsonUrl);
            ViewBag.Title = "Home Page";

            return View(jsonResponse);
        }
    }
}
