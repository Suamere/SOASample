using System;
using System.Collections.Generic;

namespace WebFletch.Order.Data.Entities
{
    public class CreditCardView
    {
        private DateTime _expirationDate;
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime ExpirationDate
        {
            get
            {
                return _expirationDate;
            }
            set
            {
                var nextMonth = value.AddMonths(1);
                _expirationDate = (new DateTime(nextMonth.Year, nextMonth.Month, 1, 0, 0, 0)).AddSeconds(-1);
            }
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}
