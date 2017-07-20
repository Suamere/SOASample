using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFletch.Order.Models
{
    public class OrderDetailModel
    {
        public int OrderLine { get; set; }
        public int ItemID { get; set; }
        public decimal Quantity { get; set; }
        public string ItemCode { get; set; }
        public Dictionary<string, decimal> Totals { get; set; }

        public int OrderID { get; set; }

        
    }
}
