using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class GenreMasterRepository : Repository<GenreMaster>, IGenreMasterRepository
    {
        public GenreMasterRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}