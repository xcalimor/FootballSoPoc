using LeagueApi.Model;
using LeagueResourceAccess.Protos;
using Microsoft.AspNetCore.Mvc;
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

        private League Map(LeagueMessage from)
        {
            var mapped =  new League
            {
                LeagueId = from.LeagueId,
                LeagueName = from.Name
            };
            return mapped;
        }

        private Model.LeagueTeam Map(LeagueTeamsMessage from)
        {
            var mapped = new LeagueTeam
            {
                LeagueTeamId = from.LeagueTeamId,
                TeamId = from.TeamId,
                TeamName = "Unknown"
            };

            return mapped;
        }
    }
}
