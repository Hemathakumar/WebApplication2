using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace webapiversion
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
           System.Diagnostics.Debug.WriteLine(" Application_Start fired");
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          
        }
        protected void Application_BeginRequest()
        {
            // Fires at the beginning of every HTTP request
            System.Diagnostics.Debug.WriteLine("Application_BeginRequest fired: " + Request.Url);
        }

        protected void Application_Error()
        {
            // Fires on unhandled exceptions
            Exception ex = Server.GetLastError();
            System.Diagnostics.Debug.WriteLine("Application_Error fired: " + ex?.Message);
        }

        protected void Application_End()
        {
            // Fires when the app shuts down
            System.Diagnostics.Debug.WriteLine(" Application_End fired");
            Session.Clear();
        }

    }
}
