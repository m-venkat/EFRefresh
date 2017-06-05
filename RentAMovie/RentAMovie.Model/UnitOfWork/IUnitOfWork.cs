using System;
using RentAMovie.Model.Repository;

namespace RentAMovie.Model
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        ICustomerContactRepository CustomerContacts { get; }
        IAddressRepository CustomerAddress { get; }
        ICrewMasterRepository Crews { get; }
        IMovieMasterRepository Movies { get; }
        int SaveChanges();
    }
}