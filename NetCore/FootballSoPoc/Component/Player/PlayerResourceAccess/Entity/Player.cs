using System;

namespace PlayerResourceAccess.Entity
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Guid TeamId { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Stamina { get; set; }
        public int Reaction { get; set; }
        public int GameIQ { get; set; }
        public int Offensive { get; set; }
        public int Deffensive { get; set; }
    }
}
