using System;
using System.ComponentModel.DataAnnotations;

namespace PlayerResourceAccess.Entity
{
    public class GoalStatsDetail
    {
        [Key]
        public Guid PlayerId { get; set; }
        public bool GoalMadeNotSaved { get; set; }
        public DateTime At { get; set; }
        public int GameTime { get; set; }
        public Guid InLeagueId { get; set; }
        public Guid ForTeamId { get; set; }

    }
}
