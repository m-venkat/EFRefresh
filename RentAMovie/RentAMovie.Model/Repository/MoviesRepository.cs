using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class MoviesRepository : Repository<MovieMaster>, IMovieMasterRepository
    {
        public MoviesRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}