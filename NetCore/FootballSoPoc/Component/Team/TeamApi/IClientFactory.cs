using TeamResourceAccess.Protos;

namespace TeamApi
{
    public interface IClientFactory
    {
        ResourceAccess.ResourceAccessClient GetResourceAccessClient();
    }
}
