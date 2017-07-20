using Suamere.Utilities.SimpleResolver;
using System;

namespace WebFletch.Order.Web
{
    public partial class CompositionRoot : SuaCompositionRoot
    {
        protected static string _connectionString = null;

        protected override object GetService(Type type, Type whenInjectedInto)
        {
            // Leave this here for MicroService Cross-Cutting-Concerns
            if (Suamere.MicroService.CompositionRoot.ControlsTypeTest(type)) return Suamere.MicroService.CompositionRoot.GetService(type);

            if (_connectionString == null)
            {
                _connectionString = "";
            }

            var apiController = InjectApiController(type, whenInjectedInto);
            if (apiController != null) return apiController;

            var domainService = InjectDomainService(type, whenInjectedInto);
            if (domainService != null) return domainService;

            var backend = InjectBackend(type, whenInjectedInto);
            if (backend != null) return backend;

            var other = InjectThirdParty(type, whenInjectedInto);
            if (other != null) return other;

            // Default (Should always be null, Web API and MVC Convention)
            return null;
        }
    }
}