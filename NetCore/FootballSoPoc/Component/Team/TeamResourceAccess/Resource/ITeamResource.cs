using System.Linq;
using TeamResourceAccess.Entity;

namespace TeamResourceAccess.Resource
{
    public interface ITeamResource
    {
        IQueryable<Team> GetAllTeams();
        Team UpdateTeam(Team team);
    }
}
