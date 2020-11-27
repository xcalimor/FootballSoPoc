using System;

namespace LeagueResourceAccess.Entity
{
    public class LeagueTemplate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsEliminiatingCup { get; set; }
        public int PointsOnWin { get; set; }
        public int PointsOnDraw { get; set; }
        public int TimesPlayingEachOther { get; set; }
    }
}
