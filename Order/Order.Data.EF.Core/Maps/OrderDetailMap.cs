using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetailEntity>
    {
        public OrderDetailMap()
        {
            //key  
            HasKey(k => new { k.OrderID, k.OrderLine });

            //Mapping
            HasRequired(x => x.Order).WithMany(x => x.Details);

            //property  
            Property(p => p.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.OrderLine);
            Property(p => p.ItemCode);
            // . . .

            //table  
            ToTable("Order.Details");
        }
    }
}