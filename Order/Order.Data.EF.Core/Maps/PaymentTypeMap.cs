using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class PaymentTypeMap : EntityTypeConfiguration<PaymentTypeEntity>
    {
        public PaymentTypeMap()
        {
            //key  
            HasKey(k => k.PaymentTypeID);

            //Mapping

            //property  
            Property(p => p.PaymentTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description);

            //table  
            ToTable("dbo.PaymentTypes");
        }
    }
}