using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueResourceAccess.Entity
{
    public class LeagueTeam
    {
        public Guid Id { get; set; }
        
        [ForeignKey("LeagueId")]
        public Guid LeagueId { get; set; }
        public Guid TeamId { get; set; }
        public int Rank { get; set; }
    }
}
