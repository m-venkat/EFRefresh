using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using RentAMovie.Model;

namespace RentAMovie.Context
{
    public class RentAMovieDBContext : DbContext
    {
        public RentAMovieDBContext() : base("name=MovieDataModel")
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }

        public DbSet<MovieMaster> Movies { get; set; }
        public DbSet<CrewMaster> Crews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Customer Initialization

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.Property(t => t.CustomerId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            customerEntity.HasKey(t => t.CustomerId);

            customerEntity.Property(t => t.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired();

            customerEntity.Property(t => t.DateOfBirth)
                .HasColumnType("Date");

            customerEntity
                .HasMany(t => t.Address)
                .WithRequired(t => t.Customer);

            #endregion

            #region Address Initialization

            var addressEntity = modelBuilder.Entity<Address>();
            addressEntity.HasKey(t => new {t.CustomerId, t.AddressTypeId, t.Active});

            addressEntity.Property(t => t.CustomerId).IsRequired();
            addressEntity.Property(t => t.AddressTypeId).IsRequired();
            addressEntity.Property(t => t.Active).IsRequired();
            addressEntity.Property(t => t.AddressLine1)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Address Line 1");
            addressEntity.Property(t => t.AddressLine2)
                .IsUnicode(false)
                .HasMaxLength(100)
                .HasColumnName("Address Line 2");

            addressEntity.HasRequired(t => t.Customer)
                .WithRequiredPrincipal();
            addressEntity.HasRequired(t => t.AddressType)
                .WithMany()
                .HasForeignKey(t => t.AddressTypeId);

            #endregion

            #region AddressType Initialization

            var addressTypeEntity = modelBuilder.Entity<AddressType>();
            addressTypeEntity.HasKey(t => t.AddressTypeId);
            addressTypeEntity.Property(t => t.AddressTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            addressTypeEntity.Property(t => t.AddressTypeDesc)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("Address Type");

            #endregion

            #region Customer Contact Initialization

            var customerContactEntity = modelBuilder.Entity<CustomerContact>();
            customerContactEntity.HasKey(t => t.CustomerId);


            customerContactEntity.Property(t => t.CellPhone)
                .IsUnicode(false)
                .HasMaxLength(12)
                .IsOptional();

            customerContactEntity.Property(t => t.LandLine)
                .IsUnicode(false)
                .HasMaxLength(12)
                .IsOptional();

            customerContactEntity.Property(t => t.Email)
                .IsUnicode(false)
                .HasMaxLength(255)
                .IsRequired();

            customerContactEntity.HasRequired(t => t.Customer)
                .WithRequiredDependent();

            #endregion

            #region MovieMaster Initialization

            var movieMasterEntity = modelBuilder.Entity<MovieMaster>();
            movieMasterEntity.HasKey(t => t.MovieId);
            movieMasterEntity.Property(t => t.MovieId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            movieMasterEntity.Property(t => t.Name)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired();

            movieMasterEntity.Property(t => t.Trailer)
                .IsUnicode(false)
                .HasMaxLength(500)
                .IsOptional();

            movieMasterEntity.Property(t => t.Rating)
                .IsOptional();

            movieMasterEntity.Property(t => t.ReleaseYear)
                .IsOptional();

            movieMasterEntity.HasRequired(t => t.GenreMaster)
                .WithRequiredPrincipal();

            #endregion

            #region MovieCrew Initialization

            var movieCrewEntity = modelBuilder.Entity<MovieCrew>();
            movieCrewEntity.HasKey(t => new {t.MovieCrewId, t.MovieId});

            movieCrewEntity.HasRequired(t => t.MovieMaster)
                .WithMany();

            movieCrewEntity.HasRequired(t => t.CrewMaster)
                .WithRequiredPrincipal();

            #endregion

            #region MovieCrew Initialization

            var genreMasterEntity = modelBuilder.Entity<GenreMaster>();
            genreMasterEntity.HasKey(t => t.GenreId);
            genreMasterEntity.Property(t => t.GenreId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            genreMasterEntity.Property(t => t.GenreName)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired();

            genreMasterEntity.HasMany(t => t.Movies)
                .WithRequired(e => e.GenreMaster);

            #endregion


            #region MovieCrew Initialization

            var crewMasterEntity = modelBuilder.Entity<CrewMaster>();
            crewMasterEntity.HasKey(t => t.CrewId);
            crewMasterEntity.Property(t => t.CrewId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            crewMasterEntity.Property(t => t.Name)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired();

            crewMasterEntity.Property(t => t.WikiPage)
                .IsUnicode(false)
                .HasMaxLength(300)
                .IsOptional();

            crewMasterEntity.Property(t => t.Sex)
                .IsUnicode(false)
                .HasMaxLength(1)
                .IsRequired();

            crewMasterEntity.Property(t => t.BirthDate)
                .HasColumnType("date")
                .IsOptional();

            #endregion

            #region CrewRole Initialization

            var crewRoleEntity = modelBuilder.Entity<CrewRole>();
            crewRoleEntity.HasKey(t => t.CrewRoleId);
            crewRoleEntity.Property(t => t.CrewRoleId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            crewRoleEntity.Property(t => t.RoleName)
                .IsUnicode(false)
                .HasMaxLength(100)
                .IsRequired();

            crewRoleEntity.HasMany(t => t.Crews)
                .WithRequired(t => t.CrewRole);

            #endregion
        }
    }
}