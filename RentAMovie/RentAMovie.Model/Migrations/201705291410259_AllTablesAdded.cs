using System.Data.Entity.Migrations;

namespace RentAMovie.Model.Migrations
{
    public partial class AllTablesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.CustomerContacts",
                    c => new
                    {
                        CustomerId = c.Long(false),
                        CellPhone = c.String(maxLength: 12, unicode: false),
                        LandLine = c.String(maxLength: 12, unicode: false),
                        Email = c.String(false, 255, unicode: false)
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);

            CreateTable(
                    "dbo.MovieMasters",
                    c => new
                    {
                        MovieId = c.Long(false, true),
                        Name = c.String(false, 100, unicode: false),
                        GenreId = c.Short(false),
                        ReleaseYear = c.Short(),
                        Rating = c.Short(),
                        Trailer = c.String(maxLength: 500, unicode: false)
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.GenreMasters", t => t.GenreId, true)
                .Index(t => t.GenreId);

            CreateTable(
                    "dbo.GenreMasters",
                    c => new
                    {
                        GenreId = c.Short(false, true),
                        GenreName = c.String(false, 100, unicode: false)
                    })
                .PrimaryKey(t => t.GenreId);

            CreateTable(
                    "dbo.MovieCrews",
                    c => new
                    {
                        MovieCrewId = c.Long(false),
                        MovieId = c.Long(false)
                    })
                .PrimaryKey(t => new {t.MovieCrewId, t.MovieId})
                .ForeignKey("dbo.MovieMasters", t => t.MovieId, true)
                .Index(t => t.MovieId);

            CreateTable(
                    "dbo.CrewMasters",
                    c => new
                    {
                        CrewId = c.Int(false, true),
                        Name = c.String(false, 100, unicode: false),
                        WikiPage = c.String(maxLength: 300, unicode: false),
                        Sex = c.String(false, 1, unicode: false),
                        BirthDate = c.DateTime(storeType: "date"),
                        CrewRoleId = c.Short(false),
                        MovieCrew_MovieCrewId = c.Long(false),
                        MovieCrew_MovieId = c.Long(false)
                    })
                .PrimaryKey(t => t.CrewId)
                .ForeignKey("dbo.CrewRoles", t => t.CrewRoleId, true)
                .ForeignKey("dbo.MovieCrews", t => new {t.MovieCrew_MovieCrewId, t.MovieCrew_MovieId})
                .Index(t => t.CrewRoleId)
                .Index(t => new {t.MovieCrew_MovieCrewId, t.MovieCrew_MovieId});

            CreateTable(
                    "dbo.CrewRoles",
                    c => new
                    {
                        CrewRoleId = c.Short(false, true),
                        RoleName = c.String(false, 100, unicode: false)
                    })
                .PrimaryKey(t => t.CrewRoleId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.MovieCrews", "MovieId", "dbo.MovieMasters");
            DropForeignKey("dbo.CrewMasters", new[] {"MovieCrew_MovieCrewId", "MovieCrew_MovieId"}, "dbo.MovieCrews");
            DropForeignKey("dbo.CrewMasters", "CrewRoleId", "dbo.CrewRoles");
            DropForeignKey("dbo.MovieMasters", "GenreId", "dbo.GenreMasters");
            DropForeignKey("dbo.CustomerContacts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CrewMasters", new[] {"MovieCrew_MovieCrewId", "MovieCrew_MovieId"});
            DropIndex("dbo.CrewMasters", new[] {"CrewRoleId"});
            DropIndex("dbo.MovieCrews", new[] {"MovieId"});
            DropIndex("dbo.MovieMasters", new[] {"GenreId"});
            DropIndex("dbo.CustomerContacts", new[] {"CustomerId"});
            DropTable("dbo.CrewRoles");
            DropTable("dbo.CrewMasters");
            DropTable("dbo.MovieCrews");
            DropTable("dbo.GenreMasters");
            DropTable("dbo.MovieMasters");
            DropTable("dbo.CustomerContacts");
        }
    }
}