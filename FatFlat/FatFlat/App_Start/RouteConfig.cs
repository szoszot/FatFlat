using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FatFlat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
          
            routes.MapRoute(
              name: "UsunMieszkanie",
              url: "Flat/Delete/{id}",
              defaults: new { controller = "Flat", action = "Delete" },
              constraints: new { id = @"\d+" }
          );
            routes.MapRoute(
           name: "SzczegolyMieszkanie",
           url: "Flat/Details/{id}",
           defaults: new { controller = "Flat", action = "Details", id = UrlParameter.Optional }
 
       );
           routes.MapRoute(
               name: "EdytujMieszkanie",
               url: "Flat/Edit/{id}",
                defaults: new { controller = "Flat", action = "Edit", id = UrlParameter.Optional }
               );

            routes.MapRoute(
              name: "Nowe mieszkanie",
              url: "Flat/Create",
              defaults: new { controller = "Flat", action = "Create" }
              
          );
            routes.MapRoute(
           name: "SzczegolyKomentarz",
           url: "Comment/Details/{id}",
           defaults: new { controller = "Comment", action = "Details", id = UrlParameter.Optional }
       );
            routes.MapRoute(
       name: "EdytujKomentarz",
       url: "Comment/Edit/{id}",
       defaults: new { controller = "Comment", action = "Edit", id = UrlParameter.Optional }
   );

            routes.MapRoute(
              name: "UsunKomentarz",
              url: "Comment/Delete/{id}",
              defaults: new { controller = "Comment", action = "Delete" },
              constraints: new { id = @"\d+" }
          );
            routes.MapRoute(
           name: "NowyKomentarz",
           url: "Comment/Create/",
           defaults: new { controller = "Comment", action = "Create" }
        
       );
            routes.MapRoute(
              name: "UsunUzytkownika",
              url: "User/Delete/{id}",
              defaults: new { controller = "User", action = "Delete" },
              constraints: new { id = @"\d+" }
          );
               routes.MapRoute(
              name: "NowyUzytkownik",
              url: "User/Create/",
              defaults: new { controller = "User", action = "Create" }
          );
               routes.MapRoute(
                     name: "SzczegolyUzytkownik",
                     url: "User/Details/{id}",
                     defaults: new { controller = "User", action = "Details", id = UrlParameter.Optional }

                 );
               routes.MapRoute(
                   name: "EdytujUzytkownika",
                   url: "User/Edit/{id}",
                    defaults: new { controller = "User", action = "Edit", id = UrlParameter.Optional }
                   );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Flat", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}