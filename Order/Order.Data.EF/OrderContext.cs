using WebFletch.Order.Data.Entities;
using System.Data.Entity;

namespace WebFletch.Order.Data.EF
{
    public partial class OrderContext
    {
        public DbSet<OrderTestEntity> Tests { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderDetailEntity> OrderDetails { get; set; }
        public DbSet<PaymentTypeEntity> PaymentTypes { get; set; }
        public DbSet<RecurringOrderFrequencyEntity> RecurringOrderFrequencies { get; set; }
        public DbSet<OrderCacheEntity> Cache { get; set; }
    }
}