using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suamere.Utilities.Monad;
using WebFletch.Order.Data.Core;
using WebFletch.Order.Data.Entities;

namespace Order.UnitTests.Mocks
{
    [TestClass]
    public class PaymentRepoMock : IPaymentRepo
    {
        public Task<Maybe<bool>> ChargeCreditCardForOrder(CreditCardView card, int orderID)
        {
            throw new NotImplementedException();
        }

        public Task<Maybe<bool>> CreateExpectedPaymentAsync(ExpectedPaymentView payment, int orderID)
        {
            throw new NotImplementedException();
        }

        public Task<Maybe<bool>> CreatePaymentAsync(OrderEntity orderWithPayment)
        {
            throw new NotImplementedException();
        }

        public List<PaymentEntity> GetPaymentsByTellerNumber(string tellerNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Maybe<bool>> SetCustomerCreditCard(CreditCardView card, int customerID)
        {
            throw new NotImplementedException();
        }
    }
}