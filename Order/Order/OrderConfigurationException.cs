using System;
namespace WebFletch.Order
{
    public class OrderConfigurationException : Exception
    {
        public OrderConfigurationException(string message) : base(message) { }
    }
}