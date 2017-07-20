using System;

namespace WebFletch.Order.Models
{
    public class BankDepositModel
    {
        public string BankName { get; set; }
        public string TellerNumber { get; set; }
        public string DepositorName { get; set; }
        public decimal AmountDeposited { get; set; }
        public DateTime DepositDate { get; set; }
    }
}