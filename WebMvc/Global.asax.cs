﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using WebMvc.App_Start;

namespace WebMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);           
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
