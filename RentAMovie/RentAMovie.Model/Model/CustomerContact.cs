namespace RentAMovie.Model
{
    public class CustomerContact : BaseModel
    {
        public long CustomerId { get; set; }
        public string CellPhone { get; set; }
        public string LandLine { get; set; }
        public string Email { get; set; }
        public virtual Customer Customer { get; set; }
    }
}