using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class OrderCacheMap : EntityTypeConfiguration<OrderCacheEntity>
    {
        public OrderCacheMap()
        {
            //key  
            HasKey(k => k.OrderCacheID);

            //Mapping

            //property  
            Property(p => p.OrderCacheID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Region);
            Property(p => p.Key);
            // . . .
            
            //table  
            ToTable("Order.Cache");
        }
    }
}