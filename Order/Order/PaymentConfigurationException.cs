using System;
namespace WebFletch.Order
{
    public class PaymentConfigurationException : Exception
    {
        public PaymentConfigurationException(string message) : base(message) { }
    }
}