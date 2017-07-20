using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class OrderMap : EntityTypeConfiguration<OrderEntity>
    {
        public OrderMap()
        {
            //key  
            HasKey(k => k.OrderID);

            //Mapping
            HasOptional(x => x.Payment).WithRequired(x => x.Order);

            //property  
            Property(p => p.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.CustomerID);
            Property(p => p.OrderType);
            // . . . 

            //table  
            ToTable("Order.Orders");
        }
    }
}