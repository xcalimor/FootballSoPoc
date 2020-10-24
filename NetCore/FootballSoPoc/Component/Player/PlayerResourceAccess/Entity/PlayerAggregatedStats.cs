using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerResourceAccess.Entity
{
    public class PlayerAggregatedStats
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public Guid Team { get; set; }
        public Guid LeagueId { get; set; }
        public int GamesPlayed { get; set; }
        public int GoalsMade { get; set; }
        public int Assists { get; set; }
        public int GoalsSaved { get; set; }
        public int MinutesPlayed { get; set; }
    }
}
