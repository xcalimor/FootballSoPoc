namespace LeagueApi.Model
{
    public class LeagueGameDay
    {
        public string GameDayId { get; set; }
        public string LeagueId { get; set; }
        public string SheduledAt { get; set; }
        public LeagueTeam HomeTeam{ get; set; }
        public LeagueTeam AwayTeam{ get; set; }
    }
}
