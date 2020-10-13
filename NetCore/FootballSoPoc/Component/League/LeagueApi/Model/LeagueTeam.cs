using System;

namespace LeagueApi.Model
{
    public class LeagueTeam
    {
        public Guid LeagueTeamId { get; set; }
        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
