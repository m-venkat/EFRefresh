namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CustomerId { get; set; }

        [Column("Address Line 1")]
        [Required]
        [StringLength(100)]
        public string Address_Line_1 { get; set; }

        [Column("Address Line 2")]
        [StringLength(100)]
        public string Address_Line_2 { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string State { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short AddressTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Active { get; set; }

        public virtual AddressType AddressType { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
