using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueResourceAccess.Entity
{
    public class Standing
    {
        public Guid Id { get; set; }

        [ForeignKey("LeagueId")]
        public Guid LeagueId { get; set; }
        public Guid LeagueTeamId { get; set; }
        public Guid MemberId { get; set; }
        public int HomeGames { get; set; }
        public int AwayGames { get; set; }
        public int HomeWins { get; set; }
        public int AwayWins { get; set; }
        public int Draw { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsMade { get; set; }
        public int Points { get; set; }
    }
}
