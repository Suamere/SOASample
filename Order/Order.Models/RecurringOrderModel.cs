using System;

namespace WebFletch.Order.Models
{
    public class RecurringOrderModel : OrderModel
    {
        public int FrequencyTypeID { get; set; }
        public DateTime StartDate { get; set; }
    }
}