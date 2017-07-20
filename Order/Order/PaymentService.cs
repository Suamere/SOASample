using System;
using System.Threading.Tasks;
using WebFletch.Order.Core;
using WebFletch.Order.Data.Core;
using WebFletch.Order.Models;

namespace WebFletch.Order
{
    public class PaymentService : IPaymentService
    {
        private IPayPalService _payPalService;
        private IPaymentRepo _paymentRepo;
        private IOrderCache _cache;

        public PaymentService(IPayPalService payPalService, IPaymentRepo paymentRepo, IOrderCache cache)
        {
            _paymentRepo = paymentRepo;
            _cache = cache;
            _payPalService = payPalService;
        }

        public async Task<PaymentResponseModel> ProcessPaymentAsync(PaymentModel payment, int orderID, int marketID, string payPalRedirectProtocolAndDomain = "")
        {
            return await Task.FromResult(new PaymentResponseModel());
        }

        public async Task<PaymentResponseModel> ProcessPaymentAsync(PaymentModel payment, OrderModel order, int marketID, string payPalRedirectProtocolAndDomain = "")
        {
            return await Task.FromResult(new PaymentResponseModel());
        }

        public void CheckPaymentValidity(PaymentModel payment, int marketID)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentResponseModel> SetCustomerCreditCard(CreditCardModel creditCard, int customerID)
        {
            return await Task.FromResult(new PaymentResponseModel());
        }
    }
}