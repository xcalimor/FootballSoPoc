using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamResourceAccess.Entity
{
    public class TeamManagerContract
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public int RemainingYears { get; set; }
        public int InYears { get; set; }
    }
}
