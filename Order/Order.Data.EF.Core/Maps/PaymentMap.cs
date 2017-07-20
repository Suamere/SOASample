using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class PaymentMap : EntityTypeConfiguration<PaymentEntity>
    {
        public PaymentMap()
        {
            //key  
            HasKey(k => k.PaymentID);

            //Mapping

            //property  
            Property(x => x.PaymentAmount);
            // . . . 

            //table  
            ToTable("Order.Payments");
        }
    }
}