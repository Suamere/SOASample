using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class RecurringOrderFrequencyMap : EntityTypeConfiguration<RecurringOrderFrequencyEntity>
    {
        public RecurringOrderFrequencyMap()
        {
            //key  
            HasKey(k => k.FrequencyID);

            //Mapping

            //property  
            Property(p => p.FrequencyID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description);
            Ignore(p => p.Enabled);

            //table  
            ToTable("dbo.FrequencyTypes");
        }
    }
}