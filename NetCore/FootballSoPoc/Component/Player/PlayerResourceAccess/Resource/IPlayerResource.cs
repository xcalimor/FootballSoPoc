using PlayerResourceAccess.Entity;
using System.Linq;

namespace PlayerResourceAccess.Resource
{
    public interface IPlayerResource
    {
        IQueryable<Player> GetAllPlayer();
    }
}
