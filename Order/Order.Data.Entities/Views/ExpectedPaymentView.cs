using System;

namespace WebFletch.Order.Data.Entities
{
    public class ExpectedPaymentView
    {
        public string BankName { get; set; }
        public string TellerNumber { get; set; }
        public string DepositorName { get; set; }
        public decimal AmountDeposited { get; set; }
        public DateTime DepositDate { get; set; }
    }
}