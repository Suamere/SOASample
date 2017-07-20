using Suamere.Utilities.Monad;
using System.Threading.Tasks;
using WebFletch.Order.Models;

namespace WebFletch.Order.Core
{
    public interface IPaymentService
    {
        Task<PaymentResponseModel> ProcessPaymentAsync(PaymentModel payment, int orderID, int marketID, string payPalRedirectProtocolAndDomain = "");
        Task<PaymentResponseModel> ProcessPaymentAsync(PaymentModel payment, OrderModel order, int marketID, string payPalRedirectProtocolAndDomain = "");
        Task<PaymentResponseModel> SetCustomerCreditCard(CreditCardModel creditCard, int customerID);
        void CheckPaymentValidity(PaymentModel payment, int marketID);
    }
}