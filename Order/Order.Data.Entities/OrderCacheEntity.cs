using System;
using System.Collections.Generic;
using WebFletch.Order.Data.Entities.Enums;

namespace WebFletch.Order.Data.Entities
{
    public class OrderCacheEntity
    {
        public int OrderCacheID { get; set; }
        public string Region { get; set; }
        public string Key { get; set; }
        public string ValueJSON { get; set; }
        public DateTime CreatedDateUTC { get; set; }
        public int SecondsToLive { get; set; }
        public bool IsExpired
        {
            get
            {
                return DateTime.UtcNow >= CreatedDateUTC.AddSeconds(SecondsToLive);
            }
        }

    }
}