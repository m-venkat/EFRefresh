using RentAMovie.Context;
using RentAMovie.Model.Repository;

namespace RentAMovie.Model
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly RentAMovieDBContext _context;
        private ICustomerRepository _customers;
        private ICustomerContactRepository _customerContacts;
        private IAddressRepository _customerAddress;
        private ICrewMasterRepository _crews;
        private IMovieMasterRepository _movies;

        public UnitOfWork(RentAMovieDBContext context)
        {
            _context = context;
        }

        public ICustomerRepository Customers => _customers ?? (_customers = new CustomerRepository(_context));

        public ICustomerContactRepository CustomerContacts => _customerContacts ??
                                                              (_customerContacts =
                                                                  new CustomerContactRepository(_context));

        public IAddressRepository CustomerAddress => _customerAddress ??
                                                     (_customerAddress = new AddressRepository(_context));

        public ICrewMasterRepository Crews => _crews ?? (_crews = new CrewMasterRepository(_context));

        public IMovieMasterRepository Movies => _movies ?? (_movies = new MoviesRepository(_context));


        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}