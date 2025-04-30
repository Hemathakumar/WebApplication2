using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace demotest3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // var cors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(cors);
            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            // Web API routes

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
