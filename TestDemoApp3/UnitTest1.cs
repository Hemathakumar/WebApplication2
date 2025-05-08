using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExampleforEntityframework.Controllers;
using ExampleforEntityframework.Models;
using System.Web.Mvc;

namespace TestDemoApp3
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
            Assert.AreEqual("Index", result.ViewName);
        }
        [TestMethod]
        public void Details_InvalidId()
        {
            Employee obj = new Employee() { Address = "HYD", Department = "IT", Id = 111, Name = "kumar", Pincode = 515551, Salary = 1000 };
            var controller = new HomeController();
            var result = controller.Details(obj) as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsNotInstanceOfType(result,typeof(HttpNotFoundResult));
        }
        [TestMethod]
        public void Details_NullEmployee_ReturnsDetailsView()
        {
            var controller = new HomeController();

            var result = controller.Details(null) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("DetailsView", result.ViewName);
        }
        [TestMethod]
        public void Details_ValidEmployee_ReturnsDetailsView()
        {
            var controller = new HomeController();
            var emp = new Employee { Id = 1, Name = "John" };

            var result = controller.Details(emp) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("DetailsView", result.ViewName);
        }
    }
}
