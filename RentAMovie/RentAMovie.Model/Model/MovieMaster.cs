namespace RentAMovie.Model
{
    public class MovieMaster : BaseModel
    {
        public long MovieId { get; set; }
        public string Name { get; set; }
        public short GenreId { get; set; }
        public short? ReleaseYear { get; set; }
        public short? Rating { get; set; }
        public string Trailer { get; set; }
        public virtual GenreMaster GenreMaster { get; set; }
    }
}