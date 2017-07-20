using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebFletch.Order.Data.Entities;

namespace WebFletch.Order.Data.EF.Core.Maps
{
    public class TestMap : EntityTypeConfiguration<OrderTestEntity>
    {
        public TestMap()
        {
            //key  
            HasKey(k => k.TestId);

            //Mapping

            //property  
            Property(p => p.TestId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.TestDescription);
            Property(p => p.CreatedDate).HasColumnType("datetime2").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            //table  
            ToTable("Order.Test");
        }
    }
}