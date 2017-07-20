using System.Collections.Generic;

namespace WebFletch.Order.Data.Entities
{
    public class PaymentTypeEntity
    {
        private string _description { get; set; }
        public int PaymentTypeID { get; set; }
        public string Description { get; set; }
    }
}