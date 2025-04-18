using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                UserRepository userrepo = new UserRepository();
                userrepo.AddUser(user);

                ViewBag.msg="user Created";
                return View("DisplayUsers", userrepo.GetAllUsers());
            }
            return View();
        }


        public ActionResult DisplayUsers()
        {

            UserRepository userrepo = new UserRepository();
            List<User> emplist = userrepo.GetAllUsers();
            return View(emplist);
        }
        

    }
}