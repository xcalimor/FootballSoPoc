using LeagueResourceAccess.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeagueResourceAccess.Resource
{
    public class LeagueResource : ILeagueResource
    {
        private readonly ILogger<LeagueResource> _logger;
        private readonly ResourceContext _resourceContext;

        public LeagueResource(ILogger<LeagueResource> logger, ResourceContext resourceContext)
        {
            _logger = logger;
            _resourceContext = resourceContext;
        }
        public IQueryable<League> GetAllLeagues()
        {
            try
            {
                return _resourceContext.Set<League>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
