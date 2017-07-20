using System;
using System.Collections.Generic;
using WebFletch.Order.Data.Entities.Enums;

namespace WebFletch.Order.Data.Entities
{
    public class ConversionRateEntity
    {
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
    }
}