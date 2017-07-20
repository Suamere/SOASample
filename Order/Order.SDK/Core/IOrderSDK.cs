using Suamere.Utilities.Monad;
using System;
using System.Collections.Generic;
using WebFletch.Order.Models;

namespace WebFletch.Order.SDK.Core
{
    public interface IOrderSDK
    {
        // Gets
        Maybe<List<OrderModel>> GetOrderDetailsForCustomerInDateRange(int cutomerId, DateTime startDate, DateTime endDate);
        Maybe<List<OrderModel>> GetOrdersInDateRange(DateTime startDate, DateTime endDate);
        Maybe<List<OrderDetailModel>> GetOrderDetails(int orderId);

        // Filters

        // Changes
    }
}