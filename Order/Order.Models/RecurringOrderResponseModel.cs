using System;

namespace WebFletch.Order.Models
{
    public class RecurringOrderResponseModel
    {
        public RecurringOrderModel RecurringOrder { get; set; }
        public string RedirectURL { get; set; }
        public string ExceptionMessage { get; set; }
        public bool Success { get; set; }
    }
}