using System.Collections.Generic;
using WebFletch.Order.Data.Entities;
using WebFletch.Order.Data.Core;
using System;
using System.Threading.Tasks;
using Suamere.Utilities.Monad;

namespace WebFletch.Order.Data.EF.Repos
{
    public class PaymentRepo : IPaymentRepo
    {
        private string _c = null;

        public PaymentRepo(string conn)
        {
            _c = conn;
        }

        public List<PaymentEntity> GetPaymentsByTellerNumber(string tellerNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<Maybe<bool>> CreatePaymentAsync(OrderEntity orderWithPayment)
        {
            return await Task.FromResult(false.ToMaybe());
        }

        public async Task<Maybe<bool>> SetCustomerCreditCard(CreditCardView card, int customerID)
        {
            return await Task.FromResult(false.ToMaybe());
        }

        public async Task<Maybe<bool>> ChargeCreditCardForOrder(CreditCardView card, int orderID)
        {
            return await Task.FromResult(false.ToMaybe());
        }

        public async Task<Maybe<bool>> CreateExpectedPaymentAsync(ExpectedPaymentView payment, int orderID)
        {
            return await Task.FromResult(false.ToMaybe());
        }
    }
}