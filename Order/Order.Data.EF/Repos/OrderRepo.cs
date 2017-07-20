using System.Collections.Generic;
using WebFletch.Order.Data.Entities;
using WebFletch.Order.Data.Core;
using System;
using Suamere.Utilities.Monad;
using System.Threading.Tasks;

namespace WebFletch.Order.Data.EF.Repos
{
    public class OrderRepo : IOrderRepo
    {
        private string _c = null;

        public OrderRepo(string conn)
        {
            _c = conn;
        }

        public List<KeyValuePair<int, string>> RecurringOrderFrequencies()
        {
            throw new NotImplementedException();
        }

        public bool CurrencyRequiresConversion(string currencyCode)
        {
            throw new NotImplementedException();
        }

        public decimal GetOrderConversionRate(string currencyCode)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetailEntity> GetOrderDetails(int orderID)
        {
            throw new NotImplementedException();
        }

        public List<OrderEntity> GetOrderDetailsForCustomerInDateRange(int cutomerId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public List<OrderEntity> GetOrdersInDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public OrderEntity GetOrderAndDetails(int orderID)
        {
            throw new NotImplementedException();
        }

        public List<OrderEntity> EnrollmentOrdersThisMonth()
        {
            throw new NotImplementedException();
        }

        public async Task<OrderEntity> CalculateOrder(OrderEntity order, int marketID)
        {
            return await Task.FromResult(new OrderEntity());
        }

        public async Task<Maybe<OrderEntity>> CreateOrder(OrderEntity order, int marketID)
        {
            return await Task.FromResult((new OrderEntity()).ToMaybe());
        }

        public async Task<Maybe<RecurringOrderEntity>> CreateRecurringOrder(RecurringOrderEntity recurringOrder, int marketID)
        {
            return await Task.FromResult((new RecurringOrderEntity()).ToMaybe());
        }
    }
}