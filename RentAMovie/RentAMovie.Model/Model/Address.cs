namespace RentAMovie.Model
{
    public class Address
    {
        public long CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public short AddressTypeId { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual AddressType AddressType { get; set; }
    }
}