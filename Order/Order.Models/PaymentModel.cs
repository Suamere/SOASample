using System;

namespace WebFletch.Order.Models
{
    public class PaymentModel
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsValid { get; set; }

        public BankDepositModel BankDeposit { get; set; }
        public CreditCardModel CreditCard { get; set; }
        public PayPalModel PayPal { get; set; }

        public bool HasCreditCard
        {
            get
            {
                return CreditCard != null;
            }
        }
        public bool HasPayPal
        {
            get
            {
                return PayPal != null;
            }
        }
        public bool HasBankDeposit
        {
            get
            {
                return BankDeposit != null;
            }
        }
    }
}