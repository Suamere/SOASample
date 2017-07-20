using Suamere.Utilities.Monad;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebFletch.Order.Models;

namespace WebFletch.Order.Core
{
    public interface IOrderService
    {
        List<OrderModel> GetOrderDetailsForCustomerInDateRange(int customerID, DateTime fromDateInt, DateTime toDateInt);
        List<OrderModel> GetOrdersInDateRange(DateTime fromDateInt, DateTime toDateInt);
        List<OrderDetailModel> GetOrderDetails(int orderID);

        Task<Maybe<OrderModel>> CalculateOrder(OrderModel order, int marketID, int languageID);
        Task<OrderResponseModel> CreateEnrollmentOrder(OrderModel order, string customerType, int marketID, int languageID, string currentProtocolAndDomain);
        Task<OrderResponseModel> CreateRegistrationRequest(OrderModel order, int marketID, int languageID, string currentProtocolAndDomain);
    }
}