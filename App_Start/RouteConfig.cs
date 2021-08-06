﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QueryRenderingApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 name: "Query Page",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Query", id = UrlParameter.Optional }
            );
        }
    }
}
