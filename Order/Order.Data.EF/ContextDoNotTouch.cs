using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Reflection;

namespace WebFletch.Order.Data.EF
{
    public partial class OrderContext : DbContext
    {
        static OrderContext()
        {
            Database.SetInitializer<OrderContext>(null);
        }

        public OrderContext(string conn) : base(conn)
        {
            Database.Log = s => Debug.WriteLine(s);
            Database.CommandTimeout = 300;
            Configuration.UseDatabaseNullSemantics = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Order");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(EF.Core.Maps.OrderMap)));
        }
    }

    public class OrderContextFactory : IDbContextFactory<OrderContext>
    {
        public OrderContext Create()
        {
            return new OrderContext("");
        }
    }
}