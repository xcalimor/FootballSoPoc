using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueResourceAccess.Entity
{
    public class GameDay
    {
        public Guid Id { get; set; }
        [ForeignKey("LeagueId")]
        public Guid LeagueId { get; set; }
        public DateTime SheduledAt { get; set; }
        public Guid HomeLeagueTeamId { get; set; }
        public Guid AwayLeagueTeamId { get; set; }
        
        public ICollection<Scorer> HomeScorers { get; set; }
        [ForeignKey("ScorerId")]
        public ICollection<Scorer> AwayScorers { get; set; }

    }
}
