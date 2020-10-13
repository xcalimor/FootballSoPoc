using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueResourceAccess.Entity
{
    public class Scorer
    {
        public Guid Id { get; set; }
        [ForeignKey("GameDayId")]
        public Guid GameDayId { get; set; }
        public Guid LeaguePlayerId { get; set; }
        public int ScoredInMinute { get; set; }
        public Guid? AssistedByLeaguePlayerId { get; set; }
    }
}
