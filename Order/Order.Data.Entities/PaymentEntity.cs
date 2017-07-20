using System;

namespace WebFletch.Order.Data.Entities
{
    public class PaymentEntity
    {
        public int PaymentID { get; set; }
        public int PaymentTypeID { get; set; }
        public decimal PaymentAmount { get; set; }
        public PaymentTypeEntity PaymentType { get; set; }

        public int OrderID { get; set; }
        public OrderEntity Order { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}