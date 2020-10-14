using Grpc.Core;
using LeagueResourceAccess.Entity;
using LeagueResourceAccess.Protos;
using LeagueResourceAccess.Resource;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueResourceAccess.Services
{
    public class LeagueResourceAccessService : ResourceAccess.ResourceAccessBase
    {
        private readonly ILogger<LeagueResourceAccessService> _logger;
        private readonly ILeagueResource _leagueResource;
        public LeagueResourceAccessService(ILogger<LeagueResourceAccessService> logger, ILeagueResource leagueResource)
        {
            _logger = logger;
            _leagueResource = leagueResource;
        }

        public override async Task<GetLeagueOnIdResponse> GetLeagueOnId(GetLeagueOnIdRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">LeagueResourceAccessService.GetLeagueOnId");
            var leagueId = Guid.Parse(request.LeagueId);
            var league = await _leagueResource.GetAllLeagues().SingleAsync(l => l.Id == leagueId);

            return new GetLeagueOnIdResponse
            {
                League = Helper.Mapper.Map(league)
            };
        }

        public override async Task<GetStandingsInLeagueResonse> GetStandingsInLeague(GetStandingsInLeagueRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">LeagueResourceAccessService.GetAllGameDaysOnLeague");

            IEnumerable<Standing> standings;
            var newOffset = 0;

            var leagueId = Guid.Parse(request.LeagueId);
            var league = await _leagueResource.GetAllLeagues().Include(l => l.GameDays).SingleAsync(l => l.Id == leagueId);

            if (request.Offset > 0 && request.Records > 0)
            {
                standings = league.Standings.Skip(request.Offset).Take(request.Records);
                newOffset = request.Offset + request.Records;
            }
            else
            {

                standings = league.Standings;

            }

            var response = new GetStandingsInLeagueResonse();
            foreach (var t in standings)
            {
                try
                {
                    var d = Helper.Mapper.Map(t);
                    response.Standings.Add(d);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    throw;
                }
            }
            response.NewOffset = newOffset;
            return response;
        }
        public override async Task<GetAllGameDaysOnLeagueResponse> GetAllGameDaysOnLeague(GetAllGameDaysOnLeagueRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">LeagueResourceAccessService.GetAllGameDaysOnLeague");

            IEnumerable<GameDay> gameDays;
            var newOffset = 0;

            var leagueId = Guid.Parse(request.LeagueId);
            var league = await _leagueResource.GetAllLeagues().Include(l => l.GameDays).SingleAsync(l => l.Id == leagueId);

            if (request.Offset > 0 && request.Records > 0)
            {
                gameDays = league.GameDays.Skip(request.Offset).Take(request.Records);
                newOffset = request.Offset + request.Records;
            }
            else
            {

                gameDays = league.GameDays;

            }

            var response = new GetAllGameDaysOnLeagueResponse();
            foreach (var t in gameDays)
            {
                try
                {
                    var d = Helper.Mapper.Map(t);
                    response.GameDays.Add(d);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    throw;
                }
            }
            response.NewOffset = newOffset;
            return response;
        }

        public override async Task<GetAllLeaguesResponse> GetAllLeagues(GetAllLeaguesRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">LeagueResourceAccessService.GetAllLeagues");

            IQueryable<League> leagues;
            var newOffset = 0;

            if(request.Offset > 0 && request.Records > 0)
            {
                leagues = _leagueResource.GetAllLeagues().Skip(request.Offset).Take(request.Records);
                newOffset = request.Offset + request.Records;
            }
            else
            {
                leagues = _leagueResource.GetAllLeagues();
            }

            var allLeagues = await leagues.ToListAsync();
            var response = new GetAllLeaguesResponse();

            foreach (var league in allLeagues.ToList())
            {
                try
                {
                    var leagueMessage = Helper.Mapper.Map(league);
                    response.Leagues.Add(leagueMessage);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    throw;
                }
            }
            response.NewOffset = newOffset;
            return response;
        }

        public override async Task<GetAllTeamsInLeagueResponse> GetAllTeamsInLeague(GetAllTeamsInLeagueRequest request, ServerCallContext context)
        {
            _logger.LogInformation(">LeagueResourceAccessService.GetAllTeamsInLeague");

            IEnumerable<LeagueTeam> teams;
            var newOffset = 0;

            var leagueId = Guid.Parse(request.LeagueId);
            var league = await _leagueResource.GetAllLeagues().Include(l => l.LeagueTeams).SingleAsync(l => l.Id == leagueId);
            

            if (request.Offset > 0 && request.Records > 0)
            {
                teams = league.LeagueTeams.Skip(request.Offset).Take(request.Records);
                newOffset = request.Offset + request.Records;
            }
            else
            {
                
                teams = league.LeagueTeams;

            }

            var response = new GetAllTeamsInLeagueResponse();
            foreach (var t in teams)
            {
                try
                {
                    var tm = Helper.Mapper.Map(t);
                    response.Teams.Add(tm);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    throw;
                }
            }
            response.NewOffset = newOffset;
            return response;

        }


    }
}
