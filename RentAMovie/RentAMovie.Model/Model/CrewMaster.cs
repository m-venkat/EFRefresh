using System;

namespace RentAMovie.Model
{
    public class CrewMaster
    {
        public int CrewId { get; set; }
        public string Name { get; set; }
        public string WikiPage { get; set; }
        public string Sex { get; set; }
        public DateTime? BirthDate { get; set; }
        public short? CrewRoleId { get; set; }
        public virtual CrewRole CrewRole { get; set; }
    }
}