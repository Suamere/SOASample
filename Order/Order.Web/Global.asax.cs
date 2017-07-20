using System.Web.Http;
using System.Web.Mvc;

namespace WebFletch.Order.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(config => { config.MapHttpAttributeRoutes(); });
            GlobalFilters.Filters.Clear();
            GlobalFilters.Filters.Add(new RequireHttpsAttribute());
        }
    }
}