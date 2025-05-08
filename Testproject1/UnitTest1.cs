using ExampleforEntityframework.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ExampleforEntityframework.Controllers;
using ExampleforEntityframework.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace Testproject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("HomeView", result.ViewName);
        }

        [TestMethod]
        public void Index_Returns_HomeView()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("HomeView", result.ViewName);
        }
        [TestMethod]
        public void Details_InvalidId_ReturnsNotFound()
        {
            var controller = new HomeController();

            var result = controller.Details(-1);

            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));
        }


    }
}
