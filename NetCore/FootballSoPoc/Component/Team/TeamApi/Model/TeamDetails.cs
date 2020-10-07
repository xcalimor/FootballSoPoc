using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamApi.Model
{
    public class TeamDetails
    {
        public Guid TeamId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ArenaName { get; set; }
        public int ArenaCapacity { get; set; }
        public string City { get; set; }
        public int CityPopulation { get; set; }
    }
}
