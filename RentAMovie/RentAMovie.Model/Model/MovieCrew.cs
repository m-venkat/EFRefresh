namespace RentAMovie.Model
{
    public class MovieCrew
    {
        public long MovieId { get; set; }
        public long MovieCrewId { get; set; }

        public virtual MovieMaster MovieMaster { get; set; }
        public virtual CrewMaster CrewMaster { get; set; }
    }
}