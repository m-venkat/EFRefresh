namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MovieCrew
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MovieCrewId { get; set; }

        [Required]
        [StringLength(100)]
        public string CrewName { get; set; }

        public short? ReleaseYear { get; set; }

        public short? Rating { get; set; }

        [Required]
        [StringLength(100)]
        public string Trailer { get; set; }
    }
}
