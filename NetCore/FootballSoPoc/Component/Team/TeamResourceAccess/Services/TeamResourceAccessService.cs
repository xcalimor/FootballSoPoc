using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TeamResourceAccess.Entity;
using TeamResourceAccess.Protos;
using TeamResourceAccess.Resource;
using SoPocFramework.CustomExtension;

namespace TeamResourceAccess.Services
{
    public class TeamResourceAccessService : ResourceAccess.ResourceAccessBase
    {
        private readonly ILogger<TeamResourceAccessService> _logger;
        private readonly ITeamResource _teamResource;

        public TeamResourceAccessService(ILogger<TeamResourceAccessService> logger, ITeamResource teamResource)
        {
            _logger = logger;
            _teamResource = teamResource;
        }

        public override async Task<GetAllTeamsResponse> GetAllTeams(Empty request, ServerCallContext context)
        {
            _logger.LogInformation(">TeamResourceAccessService.GetAllTeams");

            var allTeams = await _teamResource.GetAllTeams().ToListAsync();
            var response = new GetAllTeamsResponse();

            foreach (var team in allTeams.ToList())
            {
                try
                {
                    var teamMessage = Map(team);
                    response.Teams.Add(teamMessage);
                } catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    throw;
                }
            }

            return response;
        }

        public override async Task<GetTeamByIdResponse> GetTeamById(GetTeamByIdRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">TeamResourceAccessService.GetTeamById");
            var teamId = Guid.Parse(request.TeamId);
            var team = await _teamResource.GetAllTeams().SingleOrDefaultAsync(t => t.TeamId == teamId);

            var response = new GetTeamByIdResponse
            {
                Team = Map(team)
            };

            return response;
        }

        private TeamMessage Map(Team from)
        {
            return new TeamMessage
            {
                TeamId = from.TeamId.ToString(),
                TeamName = from.Name,
                TeamShortName = from.ShortName.ToProtoString(),
                ArenaCapacity = from.ArenaCapacity,
                ArenaName = from.ArenaName,
                CityName = (from.City == null) ? "" : from.City.Name,
                CityPopulation = (from.City == null) ? 0 : from.City.Population
            };
        }


    }
}
