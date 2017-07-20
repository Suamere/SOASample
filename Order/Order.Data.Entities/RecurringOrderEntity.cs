using System;
using System.Collections.Generic;
using WebFletch.Order.Data.Entities.Enums;

namespace WebFletch.Order.Data.Entities
{
    public class RecurringOrderEntity
    {
        public int RecurringOrderID { get; set; }
        public int FrequencyTypeID { get; set; }
        public DateTime StartDate { get; set; }


        
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public decimal VolumeTotal { get; set; }
        public decimal VolumeFromAutoshipTotal { get; set; }
        public decimal BottlesTotal { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string SubRegionMarketCode { get; set; }
        public string RegionMarketCode { get; set; }
        public string CountryMarketCode { get; set; }
        public string PostalCode { get; set; }
        public int ShipMethodID { get; set; }
        public string Notes { get; set; }
        public PaymentEntity Payment { get; set; }

        public decimal TotalNet { get { return TotalGross + TotalTax + TotalShipping; } }
        public decimal TotalGross { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalShipping { get; set; }

        public virtual ICollection<OrderDetailEntity> Details { get; set; }
    }
}