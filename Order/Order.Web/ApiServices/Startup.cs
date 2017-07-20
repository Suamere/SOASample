using Owin;
using System.Web.Http;
using Suamere.MicroService;
using Microsoft.Owin.Security.OAuth;

namespace WebFletch.Order.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var compositionRoot = new CompositionRoot();
            HttpConfiguration config = new HttpConfiguration();
            config.DependencyResolver = compositionRoot;
            ConfigureOAuth(app);

            config.Filters.Add((AuditFilter)compositionRoot.GetService(typeof(AuditFilter)));
            config.Filters.Add((KeyAuth)compositionRoot.GetService(typeof(KeyAuth)));
            config.Filters.Add((ElmahExceptionFilter)compositionRoot.GetService(typeof(ElmahExceptionFilter)));
            config.MapHttpAttributeRoutes();
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions { });
        }
    }
}
