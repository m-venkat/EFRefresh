namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwCustomerNameAndAddress")]
    public partial class vwCustomerNameAndAddress
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [Column("Address Line 1")]
        [StringLength(100)]
        public string Address_Line_1 { get; set; }

        [Column("Address Line 2")]
        [StringLength(100)]
        public string Address_Line_2 { get; set; }

        public short? AddressTypeId { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public bool? Active { get; set; }

        [StringLength(100)]
        public string State { get; set; }
    }
}
