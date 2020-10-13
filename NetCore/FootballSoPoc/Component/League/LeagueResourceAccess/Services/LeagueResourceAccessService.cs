using LeagueResourceAccess.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueResourceAccess.Services
{
    public class LeagueResourceAccessService
    {
        private readonly ILeagueResource _leagueResource;
        public LeagueResourceAccessService(ILeagueResource leagueResource)
        {
            _leagueResource = leagueResource;
        }
    }
}
