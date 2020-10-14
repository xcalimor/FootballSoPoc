using System.Collections.Generic;

namespace LeagueApi.Model
{
    public class LeagueDetails
    {
        public League League { get; set; }
        public List<LeagueTeam> Teams { get; set; }
    }
}
