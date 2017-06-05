using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDbContext => Context as RentAMovieDBContext;
    }
}