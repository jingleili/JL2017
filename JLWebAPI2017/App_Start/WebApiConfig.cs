using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace JLWebAPI2017
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //control the return type
            //clear will return nothing. 
            //config.Formatters.Clear();
            //config.Formatters.Add(new XmlMediaTypeFormatter());
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name:"Calculator",
                routeTemplate:"api/myCalculator/{id}",
                defaults:new {controller="Calculator",id=RouteParameter.Optional}
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



        }
    }
}
