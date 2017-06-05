using RentAMovie.Context;

namespace RentAMovie.Model.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(RentAMovieDBContext context) : base(context)
        {
        }

        public RentAMovieDBContext RentAMovieDBContext => Context as RentAMovieDBContext;
    }
}