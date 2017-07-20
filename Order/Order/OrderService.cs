using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Suamere.Utilities.Monad;
using WebFletch.Order.Core;
using WebFletch.Order.Data.Core;
using WebFletch.Order.Models;

namespace WebFletch.Order
{
    public class OrderService : IOrderService
    {
        private IOrderRepo _orderRepo;
        private IOrderCache _orderCache;

        public OrderService(IOrderRepo orderRepo, IOrderCache cache)
        {
            _orderRepo = orderRepo;
            _orderCache = cache;
        }

        public async Task<Maybe<OrderModel>> CalculateOrder(OrderModel order, int marketID, int languageID)
        {
            return await Task.FromResult((new OrderModel()).ToMaybe());
        }

        public async Task<OrderResponseModel> CreateEnrollmentOrder(OrderModel order, string customerType, int marketID, int languageID, string currentProtocolAndDomain)
        {
            return await Task.FromResult(new OrderResponseModel());
        }

        public async Task<OrderResponseModel> CreateRegistrationRequest(OrderModel order, int marketID, int languageID, string currentProtocolAndDomain)
        {
            return await Task.FromResult(new OrderResponseModel());
        }

        public List<OrderDetailModel> GetOrderDetails(int orderID)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> GetOrderDetailsForCustomerInDateRange(int customerID, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> GetOrdersInDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}