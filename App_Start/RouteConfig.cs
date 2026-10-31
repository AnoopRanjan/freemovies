using System.Web.Mvc;
using System.Web.Routing;

namespace CinePulse.Mvc.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MustWatch",
                url: "must-watch",
                defaults: new { controller = "Movies", action = "MustWatch" }
            );

            routes.MapRoute(
                name: "Trailers",
                url: "trailers",
                defaults: new { controller = "Trailers", action = "Index" }
            );

            routes.MapRoute(
                name: "Cinemas",
                url: "cinemas",
                defaults: new { controller = "Cinemas", action = "Index" }
            );

            routes.MapRoute(
                name: "Watch",
                url: "watch/{id}",
                defaults: new { controller = "Movies", action = "Watch", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
