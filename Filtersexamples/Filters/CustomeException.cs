﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Filtersexamples.Filters
{
    public class CustomeActionFilter : ActionFilterAttribute
    {
        //public void OnException(ExceptionContext filterContext)
        //{
        //    // Check if the exception is already handled
        //    if (filterContext.ExceptionHandled)
        //        return;

        //    // Log the exception (you can replace this with real logging)
        //    Console.WriteLine("Exception caught by CustomExceptionFilter:");
        //    Console.WriteLine(filterContext.Exception.Message);

        //    // Mark exception as handled
        //    filterContext.ExceptionHandled = true;

        //    // Redirect to a custom error page
        //    filterContext.Result = new ViewResult
        //    {
        //        ViewName = "CustomErrorPage" // You should have an Error.cshtml view
        //    };
        //}

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Code that runs BEFORE the action method starts
            Console.WriteLine("OnActionExecuting...");

        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Code that runs AFTER the action method finishes
            Console.WriteLine("OnActionExecuted...");

        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Console.WriteLine("Before rendering the result...");


        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Console.WriteLine("After result execution...");
        }
    }
    public class CustomeException : FilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Check if the exception is already handled
            if (filterContext.ExceptionHandled)
                return;

            // Log the exception (you can replace this with real logging)
            Console.WriteLine("Exception caught by CustomExceptionFilter:");
            Console.WriteLine(filterContext.Exception.Message);

            // Mark exception as handled
            filterContext.ExceptionHandled = true;

            // Redirect to a custom error page
            filterContext.Result = new ViewResult
            {
                ViewName = "CustomErrorPage" // You should have an Error.cshtml view
            };
        }


    }

    public class AllowCorsAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var response = filterContext.HttpContext.Response;
            response.AddHeader("Access-Control-Allow-Origin", "*"); // or specific origin
            response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Authorization");

            base.OnActionExecuting(filterContext);
        }
    }


}
