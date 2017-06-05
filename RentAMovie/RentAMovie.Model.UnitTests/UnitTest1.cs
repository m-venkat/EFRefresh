using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentAMovie.Context;
using RentAMovie.Model.Repository;


namespace RentAMovie.Model.UnitTests
{
    [TestClass]
    public class RentAMovieEfTests
    {
        [TestMethod]
        public void CustomerRepoCreateAndDelete()
        {
            // MovieRepository
            RentAMovieDBContext context = new RentAMovieDBContext();
            UnitOfWork uw = new UnitOfWork(context);
            string uniqueGuid = Guid.NewGuid().ToString();
            var customerName = $"Ravi-{uniqueGuid}";
            uw.Customers.Add(new Customer()
            {
               CustomerName = customerName,
               DateOfBirth = DateTime.Parse("01/01/1980")
            });
            uw.SaveChanges();
            var dob = DateTime.Parse("01/01/1980");
            var customer = uw.Customers.Find(c => c.CustomerName == customerName && c.DateOfBirth == dob)
                .FirstOrDefault();
            Assert.IsNotNull(customer, "Customer should exists");
            Assert.AreEqual(customer.CustomerName , customerName, "Added Customer Name not found");

            uw.Customers.Remove(customer);
            uw.SaveChanges();
            customer = uw.Customers.Find(c => c.CustomerName == customerName && c.DateOfBirth == dob)
                .FirstOrDefault();
            Assert.IsNull(customer, "Customer is not getting deleted");

        }
    }
}
