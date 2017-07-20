using Suamere.Utilities.Monad;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.Core
{
    public interface IOrderRepo
    {
        bool CurrencyRequiresConversion(string currencyCode);
        decimal GetOrderConversionRate(string currencyCode);
        List<OrderDetailEntity> GetOrderDetails(int orderID);
        OrderEntity GetOrderAndDetails(int orderID);
        List<OrderEntity> EnrollmentOrdersThisMonth();
        List<OrderEntity> GetOrderDetailsForCustomerInDateRange(int cutomerId, DateTime startDate, DateTime endDate);
        List<OrderEntity> GetOrdersInDateRange(DateTime startDate, DateTime endDate);
        List<KeyValuePair<int, string>> RecurringOrderFrequencies();
        Task<OrderEntity> CalculateOrder(OrderEntity order, int marketID);
        Task<Maybe<OrderEntity>> CreateOrder(OrderEntity order, int marketID);
        Task<Maybe<RecurringOrderEntity>> CreateRecurringOrder(RecurringOrderEntity recurringOrder, int marketID);
    }
}