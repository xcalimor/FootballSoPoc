using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using TeamResourceAccess.Protos;

namespace TeamApi
{
    public class ClientFactory : IClientFactory
    {
        private readonly IConfiguration _configuration;
        private ResourceAccess.ResourceAccessClient _resourceAccessClient;

        public ClientFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ResourceAccess.ResourceAccessClient GetResourceAccessClient()
        {
            if(_resourceAccessClient == null)
            {
                var channel = GrpcChannel.ForAddress(_configuration["ServiceUrl:TeamResourceAccessService"]);
                _resourceAccessClient = new ResourceAccess.ResourceAccessClient(channel);
            }
            return _resourceAccessClient;
        }
    }
}
