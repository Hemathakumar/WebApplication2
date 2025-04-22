using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleforEntityframework
{
    public class CustomException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine("Exception Occurred: " + filterContext.Exception.Message);

            // Redirect to Error Page
            filterContext.Result = new ViewResult { ViewName = "Error" };
            filterContext.ExceptionHandled = true;
        }
    }
}