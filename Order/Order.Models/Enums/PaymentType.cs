using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFletch.Order.Models.Enums
{
    public enum PaymentType
    {
        Cash = 0,
        CreditCard = 1,
        Check = 2,
        CreditVoucher = 3,
        Net30 = 4,
        Net60 = 5,
        UseCredit = 6,
        ACHDebit = 7,
        BankDraft = 8,
        WireTransfer = 9,
        PointRedemption = 10,
        COD = 11,
        MoneyOrder = 12,
        BankDeposit = 13,
        PayPal = 14,
        Other2 = 15,
        Other3 = 16,
        Wallet = 17,
    }
}
