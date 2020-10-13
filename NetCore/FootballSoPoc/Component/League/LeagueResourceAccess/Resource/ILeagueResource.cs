using LeagueResourceAccess.Entity;
using System.Linq;

namespace LeagueResourceAccess.Resource
{
    public interface ILeagueResource
    {
        IQueryable<League> GetAllLeagues();
    }
}
