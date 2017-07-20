using System;

namespace WebFletch.Order.Models
{
    public class OrderResponseModel
    {
        public OrderModel Order { get; set; }
        public int PaymentStatusID { get; set; }
        public string RedirectURL { get; set; }
        public string ExceptionMessage { get; set; }
        public bool Success { get; set; }
    }
}