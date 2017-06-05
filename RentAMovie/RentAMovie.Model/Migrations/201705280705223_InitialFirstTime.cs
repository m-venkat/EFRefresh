using System.Data.Entity.Migrations;

namespace RentAMovie.Model.Migrations
{
    public partial class InitialFirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Addresses",
                    c => new
                    {
                        CustomerId = c.Long(false),
                        AddressTypeId = c.Short(false),
                        Active = c.Boolean(false),
                        AddressLine1 =
                        c.String(name: "Address Line 1", nullable: false, maxLength: 100, unicode: false),
                        AddressLine2 = c.String(name: "Address Line 2", maxLength: 100, unicode: false),
                        State = c.String()
                    })
                .PrimaryKey(t => new {t.CustomerId, t.AddressTypeId, t.Active})
                .ForeignKey("dbo.AddressTypes", t => t.AddressTypeId, true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, true)
                .Index(t => t.CustomerId)
                .Index(t => t.AddressTypeId);

            CreateTable(
                    "dbo.AddressTypes",
                    c => new
                    {
                        AddressTypeId = c.Short(false, true),
                        AddressType = c.String(name: "Address Type", nullable: false, maxLength: 100, unicode: false)
                    })
                .PrimaryKey(t => t.AddressTypeId);

            CreateTable(
                    "dbo.Customers",
                    c => new
                    {
                        CustomerId = c.Long(false, true),
                        CustomerName = c.String(false, 100, unicode: false),
                        DateOfBirth = c.DateTime(storeType: "date")
                    })
                .PrimaryKey(t => t.CustomerId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "AddressTypeId", "dbo.AddressTypes");
            DropIndex("dbo.Addresses", new[] {"AddressTypeId"});
            DropIndex("dbo.Addresses", new[] {"CustomerId"});
            DropTable("dbo.Customers");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}