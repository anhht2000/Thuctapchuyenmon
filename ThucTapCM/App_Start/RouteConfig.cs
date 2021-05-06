using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ThucTapCM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "DetailsProduction",
                url: "san-pham/{MetaTiltle}-{id}",
                defaults: new { controller = "RenderProduct", action = "LoadDetails", id = UrlParameter.Optional },
                namespaces: new[] { "ThucTapCM.Controllers" }
            );

            routes.MapRoute(
                name: "DetailsBlog",
                url: "blog/{metaTiltle}-{blogid}",
                defaults: new { controller = "RenderProduct", action = "LoadBlog", id = UrlParameter.Optional },
                namespaces: new[] { "ThucTapCM.Controllers" }
            );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Homett", action = "Index", id = UrlParameter.Optional },
                namespaces:new[] { "ThucTapCM.Controllers" }
            );
        }
    }
}
