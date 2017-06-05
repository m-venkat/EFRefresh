namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GenreMaster")]
    public partial class GenreMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GenreMaster()
        {
            MovieMasters = new HashSet<MovieMaster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short GenreId { get; set; }

        [Required]
        [StringLength(100)]
        public string GenreName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieMaster> MovieMasters { get; set; }
    }
}
