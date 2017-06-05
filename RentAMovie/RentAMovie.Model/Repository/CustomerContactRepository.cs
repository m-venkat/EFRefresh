using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class CustomerContactRepository : Repository<CustomerContact>, ICustomerContactRepository
    {
        public CustomerContactRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}