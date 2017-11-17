using System.Web.Mvc;
using System.Web.Routing;
using AutomapperSample.Mappers;

namespace AutomapperSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Initialize all mappers
            AutoMapperInitializer.InitMappers();
        }
    }
}
