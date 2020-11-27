using LeagueResourceAccess.Entity;
using LeagueResourceAccess.Protos;
using System.Linq;

namespace LeagueResourceAccess.Services.Helper
{
    public class Mapper
    {
        public static LeagueMessage Map(League from)
        {
            return new LeagueMessage
            {
                LeagueId = from.Id.ToString(),
                Name = from.Name
            };
        }

        public static LeagueTeamsMessage Map(LeagueTeam from)
        {
            return new LeagueTeamsMessage
            {
                LeagueTeamId = from.Id.ToString(),
                LeagueId = from.LeagueId.ToString(),
                Rank = from.Rank,
                TeamId = from.TeamId.ToString()
            };
        }

        public static GameDayMessage Map(GameDay from)
        {
            var result = new GameDayMessage
            {
                LeagueId = from.LeagueId.ToString(),
                GameDayId = from.Id.ToString(),
                SheduledAt = from.SheduledAt.ToString(),
                HomeTeamLeagueTeamId = from.HomeLeagueTeamId.ToString(),
                AwayTeamLeagueTeamId = from.AwayLeagueTeamId.ToString(),
            };
            result.HomeScorers.Add(from.HomeScorers.Select(s => Map(s)));
            result.AwayScorers.Add(from.AwayScorers.Select(s => Map(s)));
            return result;
        }

        public static ScorerMessage Map(Scorer from)
        {
            return new ScorerMessage
            {
                PlayerId = from.PlayerId.ToString(),
                AssistedByLeaguePlayerId = from.AssistedByLeaguePlayerId.ToString(),
                ScoredInMinute = from.ScoredInMinute
            };
        }

        public static StandingMessage Map(Standing from)
        {
            return new StandingMessage
            {
                AwayGames = from.AwayGames,
                AwayWins = from.AwayWins,
                Draw = from.Draw,
                GoalsAgainst = from.GoalsAgainst,
                GoalsMade = from.GoalsMade,
                HomeGames = from.HomeGames,
                HomeWins = from.HomeWins,
                Id = from.Id.ToString(),
                LeagueId = from.LeagueId.ToString(),
                LeagueTeamId = from.LeagueTeamId.ToString(),
                MemberId = from.MemberId.ToString(),
                Points = from.Points
            };
        }
    }
}
