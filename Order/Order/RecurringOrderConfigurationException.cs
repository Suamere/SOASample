using System;
namespace WebFletch.Order
{
    public class RecurringOrderConfigurationException : Exception
    {
        public RecurringOrderConfigurationException(string message) : base(message) { }
    }
}