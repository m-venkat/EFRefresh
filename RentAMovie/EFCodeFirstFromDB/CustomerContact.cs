namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerContact")]
    public partial class CustomerContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CustomerId { get; set; }

        [Required]
        [StringLength(12)]
        public string CellPhone { get; set; }

        [StringLength(12)]
        public string LandLine { get; set; }

        [Required]
        [StringLength(75)]
        public string Email { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
