using Suamere.Utilities.Monad;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.Core
{
    public interface IPaymentRepo
    {
        Task<Maybe<bool>> CreatePaymentAsync(OrderEntity orderWithPayment);
        List<PaymentEntity> GetPaymentsByTellerNumber(string tellerNumber);
        Task<Maybe<bool>> SetCustomerCreditCard(CreditCardView card, int customerID);
        Task<Maybe<bool>> ChargeCreditCardForOrder(CreditCardView card, int orderID); 
        Task<Maybe<bool>> CreateExpectedPaymentAsync(ExpectedPaymentView payment, int orderID);
    }
}