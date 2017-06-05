namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrewRole")]
    public partial class CrewRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrewRole()
        {
            CrewMasters = new HashSet<CrewMaster>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CrewRoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string RoleName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrewMaster> CrewMasters { get; set; }
    }
}
