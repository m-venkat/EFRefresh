using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class MovieCrewRepository : Repository<MovieCrew>, IMovieCrewRepository
    {
        public MovieCrewRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}