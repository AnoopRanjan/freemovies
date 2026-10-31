using System;
using System.Web.Mvc;
using System.Web.Routing;
using CinePulse.Mvc.App_Start;

namespace CinePulse.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
