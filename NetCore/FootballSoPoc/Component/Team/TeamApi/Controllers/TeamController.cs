using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeamApi.Model;
using TeamResourceAccess.Protos;

namespace TeamApi.Controllers
{
    [Route("fsopoc/api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IClientFactory _clientFactory;

        public TeamController(ILogger<TeamController> logger, IClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet()]
        public async Task<IEnumerable<TeamDetails>> Get()
        {
            var request = new Google.Protobuf.WellKnownTypes.Empty();
            var client = _clientFactory.GetResourceAccessClient();
            var teams = await client.GetAllTeamsAsync(request);
            return teams.Teams.AsEnumerable().Select(t => Map(t));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var client = _clientFactory.GetResourceAccessClient();
            var response = await client.GetTeamByIdAsync(new GetTeamByIdRequest { TeamId = id });
            return Ok(Map(response.Team));
        }

        private TeamDetails Map(TeamMessage from)
        {
            return new TeamDetails
            {
                TeamId = Guid.Parse(from.TeamId),
                Name = from.TeamName,
                ShortName = from.TeamShortName,
                ArenaName = from.ArenaName,
                ArenaCapacity = from.ArenaCapacity,
                City = from.CityName,
                CityPopulation = from.CityPopulation
            };
        }
    }
}
