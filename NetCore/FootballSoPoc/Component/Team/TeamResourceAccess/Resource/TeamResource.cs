using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TeamResourceAccess.Entity;

namespace TeamResourceAccess.Resource
{
    public class TeamResource : ITeamResource
    {
        private readonly ILogger<TeamResource> _logger;
        private readonly ResourceContext _resourceContext;

        public TeamResource(ILogger<TeamResource> logger, ResourceContext resourceContext)
        {
            _logger = logger;
            _resourceContext = resourceContext;
        }
        public IQueryable<Team> GetAllTeams()
        {
            try
            {
                return _resourceContext.Set<Team>().Include(t=> t.City).Include(c=> c.TeamManagerContract);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public Team UpdateTeam(Team team)
        {
            _resourceContext.Attach(team);
            _resourceContext.SaveChanges();
            return team;
        }
    }
}
