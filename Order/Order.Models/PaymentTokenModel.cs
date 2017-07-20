using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFletch.Order.Models
{
    public class PaymentTokenModel
    {
        public int OrderID { get; set; }
        public string PayPalToken { get; set; }
        public decimal Amount { get; set; }
    }
}
