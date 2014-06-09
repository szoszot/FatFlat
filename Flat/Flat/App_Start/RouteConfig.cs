﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Flat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Dodaj",                                           // Route name
                url: "Mieszkanie/Create",                            // URL with parameters
                defaults: new { controller = "Mieszkanie", action = "Create" }  // Parameter defaults
            );
           
            routes.MapRoute(
                name: "Nowe",                                           // Route name
                url: "Mieszkanie/Create",                            // URL with parameters
                defaults: new { controller = "Mieszkanie", action = "Create" }  // Parameter defaults
            );
            routes.MapRoute(
              name: "Edycja",                                           // Route name
              url: "Mieszkanie/Edit/{id}",                            // URL with parameters
              defaults: new { controller = "Mieszkanie", action = "Edit", id = UrlParameter.Optional }); // Parameter defaults

           
        }
    }
}