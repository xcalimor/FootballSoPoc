using LeagueApi.Model;
using LeagueResourceAccess.Protos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeagueApi.Controllers
{
    [Route("fsopoc/api/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly ResourceAccess.ResourceAccessClient _resourceAccessClient;

        public LeagueController(ResourceAccess.ResourceAccessClient resourceAccessClient)
        {
            _resourceAccessClient = resourceAccessClient;
        }

        [HttpGet()]
        public async Task<IEnumerable<League>> Get()
        {
            var response = await _resourceAccessClient.GetAllLeaguesAsync(new GetAllLeaguesRequest { Offset = 0, Records = 0 });
            return response.Leagues.AsEnumerable().Select(l => Map(l));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _resourceAccessClient.GetLeagueOnIdAsync(new GetLeagueOnIdRequest { LeagueId = id });
            return Ok(response.League);
        }

        [HttpGet("{id}/team/{teamId}")]
        public async Task<IActionResult> GetTeamsOnLeague(string id, string teamId)
        {
            var response = await _resourceAccessClient.GetAllTeamsInLeagueAsync(new GetAllTeamsInLeagueRequest { LeagueId = id, Offset = 0, Records = 0 });
            var test = response.Teams.SingleOrDefault(t => t.TeamId == teamId);
            return Ok(test);
        }

        [HttpGet("{id}/team/")]
        public async Task<IEnumerable<LeagueTeam>> GetTeamOnLeagueTeam(string id, string teamId)
        {
            var response = await _resourceAccessClient.GetAllTeamsInLeagueAsync(new GetAllTeamsInLeagueRequest { LeagueId = id, Offset = 0, Records = 0 });
            return response.Teams.AsEnumerable().Select(g => Map(g));
        }

        [HttpGet("{id}/gameday/")]
        public async Task<IEnumerable<GameDay>> GetGameDaysOnLeague(string id)
        {
            var response = await _resourceAccessClient.GetAllGameDaysOnLeagueAsync(new GetAllGameDaysOnLeagueRequest { LeagueId = id, Offset = 0, Records = 0 });
            return response.GameDays.AsEnumerable().Select(g=> Map(g));
        }

        [HttpGet("{id}/standing/")]
        public async Task<IEnumerable<Standing>> GetFilesOnId(string id)
        {
            var response = await _resourceAccessClient.GetStandingsInLeagueAsync(new  GetStandingsInLeagueRequest { LeagueId = id});
            return response.Standings.AsEnumerable().Select(s => Map(s));
        }

        private League Map(LeagueMessage from)
        {
            var mapped =  new League
            {
                LeagueId = from.LeagueId,
                LeagueName = from.Name
            };
            return mapped;
        }

        private LeagueTeam Map(LeagueTeamsMessage from)
        {
            var mapped = new LeagueTeam
            {
                LeagueTeamId = from.LeagueTeamId,
                TeamId = from.TeamId,
                TeamName = "Unknown"
            };

            return mapped;
        }

        private GameDay Map(GameDayMessage from)
        {
            var mapped = new GameDay
            {
                Id = Guid.Parse(from.GameDayId),
                HomeTeam = from.HomeTeamLeagueTeamId.ToString(),
                AwayTeam = from.AwayTeamLeagueTeamId.ToString(),
                SheduledAt = from.SheduledAt
            };

            return mapped;
        }

        private Standing Map(StandingMessage from)
        {
            var mapped = new Standing
            {
                AwayGames = from.AwayGames,
                AwayWins = from.AwayWins,
                Draw = from.Draw,
                GoalsAgainst = from.GoalsAgainst,
                GoalsMade = from.GoalsMade,
                HomeGames = from.HomeGames,
                HomeWins = from.HomeWins,
                Id = Guid.Parse(from.Id),
                LeagueId = Guid.Parse(from.LeagueId),
                LeagueTeamId = Guid.Parse(from.LeagueTeamId),
                Points = from.Points
            };

            return mapped;
        }
    }
}
