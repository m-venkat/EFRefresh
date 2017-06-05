using System.Collections.Generic;

namespace RentAMovie.Model
{
    public class CrewRole
    {
        public CrewRole()
        {
            Crews = new HashSet<CrewMaster>();
        }

        public short CrewRoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<CrewMaster> Crews { get; set; }
    }
}