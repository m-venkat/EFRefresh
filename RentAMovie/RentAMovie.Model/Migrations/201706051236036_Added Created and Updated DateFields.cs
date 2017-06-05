namespace RentAMovie.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCreatedandUpdatedDateFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Addresses", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AddressTypes", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AddressTypes", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CustomerContacts", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CustomerContacts", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieMasters", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieMasters", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.GenreMasters", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.GenreMasters", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieCrews", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieCrews", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CrewMasters", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CrewMasters", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CrewRoles", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.CrewRoles", "UpdatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CrewRoles", "UpdatedDate");
            DropColumn("dbo.CrewRoles", "CreatedDate");
            DropColumn("dbo.CrewMasters", "UpdatedDate");
            DropColumn("dbo.CrewMasters", "CreatedDate");
            DropColumn("dbo.MovieCrews", "UpdatedDate");
            DropColumn("dbo.MovieCrews", "CreatedDate");
            DropColumn("dbo.GenreMasters", "UpdatedDate");
            DropColumn("dbo.GenreMasters", "CreatedDate");
            DropColumn("dbo.MovieMasters", "UpdatedDate");
            DropColumn("dbo.MovieMasters", "CreatedDate");
            DropColumn("dbo.CustomerContacts", "UpdatedDate");
            DropColumn("dbo.CustomerContacts", "CreatedDate");
            DropColumn("dbo.Customers", "UpdatedDate");
            DropColumn("dbo.Customers", "CreatedDate");
            DropColumn("dbo.AddressTypes", "UpdatedDate");
            DropColumn("dbo.AddressTypes", "CreatedDate");
            DropColumn("dbo.Addresses", "UpdatedDate");
            DropColumn("dbo.Addresses", "CreatedDate");
        }
    }
}
