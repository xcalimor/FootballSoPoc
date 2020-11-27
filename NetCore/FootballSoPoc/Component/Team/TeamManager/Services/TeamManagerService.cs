using Grpc.Core;
using System.Linq;
using System.Threading.Tasks;
using TeamManager.Protos;
using TeamResourceAccess.Protos;
using SoPocFramework.CustomExtension;

namespace TeamManager.Services
{
    public class TeamManagerService : Manager.ManagerBase
    {
        private readonly ResourceAccess.ResourceAccessClient _resourceAccessClient;

        public TeamManagerService(ResourceAccess.ResourceAccessClient resourceAccessClient)
        {
            _resourceAccessClient = resourceAccessClient;
        }
        public override async Task<GetfreeTeamsResponse> GetfreeTeams(GetfreeTeamsRequest request, ServerCallContext context)
        {
            var allTeamsResponse = await _resourceAccessClient.GetAllTeamsAsync(new Google.Protobuf.WellKnownTypes.Empty());
            var allTeams = allTeamsResponse.Teams.Where(t => t.Contract == null);
            var response = new GetfreeTeamsResponse();

            if (request.FilterValue != null)
            {
                var filterTeams = allTeams.Where(t => t.TeamName.Contains(request.FilterValue));
                foreach(var t in filterTeams)
                {
                    response.Teams.Add(Map(t));
                }
                return response;
            }

            if(request.Offset > 0 && request.RowsToReturn > 0)
            {
                var offsetTeams = allTeams.Take(request.RowsToReturn).Skip(request.Offset);
                foreach (var t in offsetTeams)
                {
                    response.Teams.Add(Map(t));
                }
                response.NewOffset = request.Offset + request.RowsToReturn;
                return response;
            }

            var returnRecords = 25;
            var rowsToReturn = returnRecords;
            if (request.RowsToReturn > 0)
                rowsToReturn = request.RowsToReturn;

            foreach (var t in allTeams.Take(rowsToReturn))
            {
                response.Teams.Add(Map(t));
            }
            response.NewOffset = returnRecords;
            return response;
        }

        private Protos.TeamMessage Map(TeamResourceAccess.Protos.TeamMessage from)
        {
            return new Protos.TeamMessage
            {
                TeamId = from.TeamId.ToString(),
                TeamName = from.TeamName,
                TeamShortName = from.TeamShortName.ToProtoString(),
                ArenaCapacity = from.ArenaCapacity,
                ArenaName = from.ArenaName,
                CityName = (from.CityName == null) ? "" : from.CityName,
                CityPopulation = from.CityPopulation
            };
        }
    }
}
