using System.Collections.Generic;

namespace WebFletch.Order.Data.Entities
{
    public class OrderDetailEntity
    {
        public int OrderLine { get; set; }
        public int ItemID { get; set; }
        public decimal Quantity { get; set; }
        public string ItemCode { get; set; }
        public Dictionary<string, decimal> Totals { get; set; }

        public int OrderID { get; set; }
        public virtual OrderEntity Order { get; set; }
    }
}