using System;
using System.Collections.Generic;

namespace RentAMovie.Model
{
    public class Customer
    {
        public Customer()
        {
            Address = new HashSet<Address>();
        }

        public long CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}