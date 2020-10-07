using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                return _resourceContext.Set<Team>().Include(t=> t.City);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
