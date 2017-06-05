using System.Collections.Generic;

namespace RentAMovie.Model
{
    public class GenreMaster

    {
    public GenreMaster()
    {
        Movies = new HashSet<MovieMaster>();
    }

    public short GenreId { get; set; }
    public string GenreName { get; set; }
    public virtual ICollection<MovieMaster> Movies { get; set; }
    }
}