using System;
using System.ComponentModel.DataAnnotations;

namespace PlayerResourceAccess.Entity
{
    public class PlayerContract
    {
        [Key]                
        public Guid TeamId { get; set; }

        [Key]
        public Guid PlayerId { get; set; }
        public int InYears { get; set; }
        public int Salary { get; set; }

    }
}
