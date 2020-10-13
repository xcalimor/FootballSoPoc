using LeagueResourceAccess.Entity;
using System.Collections.Generic;

namespace LeagueResourceAccess.Resource
{
    public interface ILeagueResource
    {
        List<League> GetAllLeagues();
    }
}
