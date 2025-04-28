using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testapp2.Models;

namespace testapp2.Controllers
{
    public class TestController : Controller
    {
        private readonly IMessageService _messageService;

        public TestController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Message = _messageService.GetMessage();
            return View();
        }

    }
}