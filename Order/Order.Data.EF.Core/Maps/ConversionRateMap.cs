using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class ConversionRateMap : EntityTypeConfiguration<ConversionRateEntity>
    {
        public ConversionRateMap()
        {
            //key  
            HasKey(k => k.CurrencyCode);

            //Mapping

            //property  
            Property(p => p.CurrencyCode).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Rate);
            // . . .

            //table  
            ToTable("Order.ConversionRates");
        }
    }
}