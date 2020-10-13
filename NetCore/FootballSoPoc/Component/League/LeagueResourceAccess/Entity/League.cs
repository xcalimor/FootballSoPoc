using System;
using System.Collections.Generic;

namespace LeagueResourceAccess.Entity
{
    public class League
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public ICollection<LeagueTeam> LeagueTeams { get; set; }
        public ICollection<GameDay> GameDays { get; set; }
        public ICollection<Standing> Standings { get; set; }
    }
}
