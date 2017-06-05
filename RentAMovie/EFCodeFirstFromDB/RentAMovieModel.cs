namespace EFCodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentAMovieModel : DbContext
    {
        public RentAMovieModel()
            : base("name=MovieDataModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<CrewMaster> CrewMasters { get; set; }
        public virtual DbSet<CrewRole> CrewRoles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<GenreMaster> GenreMasters { get; set; }
        public virtual DbSet<MovieCrew> MovieCrews { get; set; }
        public virtual DbSet<MovieMaster> MovieMasters { get; set; }
        public virtual DbSet<vwCustomerNameAndAddress> vwCustomerNameAndAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Address_Line_1)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address_Line_2)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<AddressType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AddressType>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.AddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrewMaster>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CrewMaster>()
                .Property(e => e.WikiPage)
                .IsUnicode(false);

            modelBuilder.Entity<CrewMaster>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<CrewRole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.CustomerContact)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.LandLine)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<GenreMaster>()
                .Property(e => e.GenreName)
                .IsUnicode(false);

            modelBuilder.Entity<GenreMaster>()
                .HasMany(e => e.MovieMasters)
                .WithRequired(e => e.GenreMaster)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovieCrew>()
                .Property(e => e.CrewName)
                .IsUnicode(false);

            modelBuilder.Entity<MovieCrew>()
                .Property(e => e.Trailer)
                .IsUnicode(false);

            modelBuilder.Entity<MovieMaster>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MovieMaster>()
                .Property(e => e.Trailer)
                .IsUnicode(false);

            modelBuilder.Entity<vwCustomerNameAndAddress>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vwCustomerNameAndAddress>()
                .Property(e => e.Address_Line_1)
                .IsUnicode(false);

            modelBuilder.Entity<vwCustomerNameAndAddress>()
                .Property(e => e.Address_Line_2)
                .IsUnicode(false);

            modelBuilder.Entity<vwCustomerNameAndAddress>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<vwCustomerNameAndAddress>()
                .Property(e => e.State)
                .IsUnicode(false);
        }
    }
}
