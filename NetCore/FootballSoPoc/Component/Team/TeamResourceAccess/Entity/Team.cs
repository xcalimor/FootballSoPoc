using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamResourceAccess.Entity
{
    public class Team
    {
        public Guid TeamId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ArenaName { get; set; }
        public int ArenaCapacity { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }
        public Guid CityId { get; set; }

        [ForeignKey("TeamManagerContractId")]
        public TeamManagerContract TeamManagerContract { get; set; }
        public Guid TeamManagerContractId { get; set; }

        public Guid? AccountIdSelectionLockId { get; set; }
        public DateTime LockedAt { get; set; }
    }
}
