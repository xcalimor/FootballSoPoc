using System;
using System.Collections.Generic;

namespace LeagueApi.Model
{
    public class GameDay
    {
        public Guid Id { get; set; }
        public string SheduledAt { get; set; }
        public string HomeTeam{ get; set; }
        public string AwayTeam { get; set; }

        public List<Scorer> HomeScorers { get; set; }
        public List<Scorer> AwayScorers { get; set; }
    }
}
