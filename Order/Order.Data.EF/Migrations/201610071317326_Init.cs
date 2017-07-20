namespace WebFletch.Order.Data.EF.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Order.Test",
                c => new
                {
                    TestId = c.Int(nullable: false, identity: true),
                    TestDescription = c.String(),
                    CreatedDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2", defaultValueSql: "GETUTCDATE()"),
                })
                .PrimaryKey(t => t.TestId);
        }

        public override void Down()
        {
            DropTable("Order.Test");
        }
    }
}
