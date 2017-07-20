using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suamere.Utilities.Monad;
using WebFletch.Order.Data.Core;
using WebFletch.Order.Data.Entities;

namespace Order.UnitTests.Mocks
{
    [TestClass]
    public class OrderRepoMock : IOrderRepo
    {
        public Task<OrderEntity> CalculateOrder(OrderEntity order, int marketID)
        {
            throw new NotImplementedException();
        }

        public Task<Maybe<OrderEntity>> CreateOrder(OrderEntity order, int marketID)
        {
            throw new NotImplementedException();
        }

        public Task<Maybe<RecurringOrderEntity>> CreateRecurringOrder(RecurringOrderEntity recurringOrder, int marketID)
        {
            throw new NotImplementedException();
        }

        public bool CurrencyRequiresConversion(string currencyCode)
        {
            throw new NotImplementedException();
        }

        public List<OrderEntity> EnrollmentOrdersThisMonth()
        {
            throw new NotImplementedException();
        }

        public OrderEntity GetOrderAndDetails(int orderID)
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

        public List<KeyValuePair<int, string>> RecurringOrderFrequencies()
        {
            throw new NotImplementedException();
        }
    }
}