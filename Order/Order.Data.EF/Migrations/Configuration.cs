using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace WebFletch.Order.Data.EF.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OrderContext context)
        {
            context.Tests.AddOrUpdate(new Entities.OrderTestEntity
            { TestId = 1, TestDescription = "Zero One Two", CreatedDate = new System.DateTime(2010, 01, 02), });
            context.Tests.AddOrUpdate(new Entities.OrderTestEntity
            { TestId = 2, TestDescription = "Three Four Five", CreatedDate = new System.DateTime(2013, 04, 05), });

            // Use this to populate Enum tables with Values, if necessary
        }
    }

    public static class ext
    {
        public static void SeedEnumValues<T, TEnum>(this IDbSet<T> dbSet, Func<TEnum, T> converter) where T : class => Enum.GetValues(typeof(TEnum))
                           .Cast<object>()
                           .Select(value => converter((TEnum)value))
                           .ToList()
                           .ForEach(instance => dbSet.AddOrUpdate(instance));
    }
}
