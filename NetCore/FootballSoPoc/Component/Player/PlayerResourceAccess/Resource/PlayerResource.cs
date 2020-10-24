using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlayerResourceAccess.Entity;
using System;
using System.Linq;

namespace PlayerResourceAccess.Resource
{
    public class PlayerResource : IPlayerResource
    {
        private readonly ILogger<PlayerResource> _logger;
        private readonly ResourceContext _resourceContext;

        public PlayerResource(ILogger<PlayerResource> logger, ResourceContext resourceContext)
        {
            _logger = logger;
            _resourceContext = resourceContext;
        }
        public IQueryable<Player> GetAllPlayer()
        {
            try
            {
                return _resourceContext.Set<Player>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
