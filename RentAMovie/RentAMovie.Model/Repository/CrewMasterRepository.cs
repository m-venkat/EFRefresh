using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class CrewMasterRepository : Repository<CrewMaster>, ICrewMasterRepository
    {
        public CrewMasterRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}