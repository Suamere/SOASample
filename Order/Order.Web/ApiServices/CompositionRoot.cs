using Suamere.Utilities.SimpleResolver;
using System;
using Suamere.MicroService;

namespace WebFletch.Order.Web
{
    public partial class CompositionRoot : SuaCompositionRoot
    {
        protected override object WhenInjectedInto(Type whenThis, Type isInjectedIntoThis)
        {
            throw new NotImplementedException();
        }

        private object InjectApiController(Type type, Type whenInjectedInto)
        {
            if (type == typeof(Api.TestApiController)) return new Api.TestApiController(GetService<Core.ITestOrders>());
            if (type == typeof(Api.OrderApiController)) return new Api.OrderApiController(GetService<Core.IOrderService>());

            return null;
        }

        private object InjectDomainService(Type type, Type whenInjectedInto)
        {
            if (type == typeof(Core.ITestOrders)) return new OrderTest(GetService<Data.Core.ITestRepo>());
            if (type == typeof(Core.IOrderService)) return new OrderService(GetService<Data.Core.IOrderRepo>(), GetService<Data.Core.IOrderCache>());
            if (type == typeof(Core.IRecurringOrderService)) return new RecurringOrderService(GetService<Core.IPaymentService>(), GetService<Data.Core.IOrderRepo>(), GetService<Data.Core.IOrderCache>());
            if (type == typeof(Core.IPaymentService)) return new PaymentService(GetService<Core.IPayPalService>(), GetService<Data.Core.IPaymentRepo>(), GetService<Data.Core.IOrderCache>());
            if (type == typeof(Core.IPayPalService)) return new PayPalService(GetService<Data.Core.IPaymentRepo>());

            return null;
        }

        private object InjectBackend(Type type, Type whenInjectedInto)
        {
            if (type == typeof(Data.Core.ITestRepo))
                return new Data.EF.Repos.OrderTestRepo(_connectionString);

            if (type == typeof(Data.Core.IOrderRepo))
                return new Data.EF.Repos.OrderRepo(_connectionString);

            if (type == typeof(Data.Core.IPaymentRepo))
                return new Data.EF.Repos.PaymentRepo(_connectionString);

            if (type == typeof(Data.Core.IOrderCache))
                return new Data.EF.Repos.OrderCacheRepo(_connectionString);

            return null;
        }

        private object InjectThirdParty(Type type, Type whenInjectedInto)
        {
            if (type == typeof(Suamere.Setting.SDK.Core.ISettingSDK))
            {
                var sdk = GetService<ISettingManager>().GetMicroServiceSettingFor("Setting");
                return new Suamere.Setting.SDK.Implementation.SettingSDK(new Suamere.Utilities.EndpointConnection.Executions.EndpointConnection(sdk.AccessLocation), sdk.Passkey);
            }
            
            return null;
        }
    }
}