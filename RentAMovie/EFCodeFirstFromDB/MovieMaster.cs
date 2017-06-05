namespace EFCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieMaster")]
    public partial class MovieMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public short GenreId { get; set; }

        public short? ReleaseYear { get; set; }

        public short? Rating { get; set; }

        [Required]
        [StringLength(100)]
        public string Trailer { get; set; }

        public virtual GenreMaster GenreMaster { get; set; }
    }
}
