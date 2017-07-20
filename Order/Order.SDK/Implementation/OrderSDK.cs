using System;
using System.Collections.Generic;
using Suamere.Utilities.Monad;
using WebFletch.Order.Models;
using Suamere.Utilities.EndpointConnection.Contracts;
using Suamere.Utilities.EndpointConnection.Models;

namespace WebFletch.Order.SDK.Implementation
{
    public class OrderSDK : Core.IOrderSDK
    {
        private IEndpointConnection _endpoint;
        private string _secretKey;

        public OrderSDK(IEndpointConnection endpoint, string secretKey)
        {
            _endpoint = endpoint;
            _secretKey = secretKey;
        }

        public Maybe<List<OrderModel>> GetOrderDetailsForCustomerInDateRange(int cutomerId, DateTime startDate, DateTime endDate)
        {
            try
            {
                return _endpoint.Get<List<OrderModel>>(
                      string.Format("api/Orders/GetOrderDetailsForCustomerInDateRange/{0}/{1}/{2}", cutomerId, startDate.ToUnixTime(), endDate.ToUnixTime())
                    , new HeaderAdditionsModel
                    {
                        Headers = new Dictionary<string, string> { { "secretKey", _secretKey } }
                    }).ToMaybe();
            }
            catch (System.Net.WebException ex) { return Maybe.Empty<List<OrderModel>>(ex); }
        }

        public Maybe<List<OrderModel>> GetOrdersInDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                return _endpoint.Get<List<OrderModel>>(
                      string.Format("api/Orders/GetOrdersInDateRange/{0}/{1}", startDate.ToUnixTime(), endDate.ToUnixTime())
                    , new HeaderAdditionsModel
                    {
                        Headers = new Dictionary<string, string> { { "secretKey", _secretKey } }
                    }).ToMaybe();
            }
            catch (System.Net.WebException ex) { return Maybe.Empty<List<OrderModel>>(ex); }
        }

        public Maybe<List<OrderDetailModel>> GetOrderDetails(int orderId)
        {
            try
            {
                return _endpoint.Get<List<OrderDetailModel>>(
                      string.Format("api/Orders/GetOrderDetails/{0}", orderId)
                    , new HeaderAdditionsModel
                    {
                        Headers = new Dictionary<string, string> { { "secretKey", _secretKey } }
                    }).ToMaybe();
            }
            catch (System.Net.WebException ex) { return Maybe.Empty<List<OrderDetailModel>>(ex); }
        }
    }
}
