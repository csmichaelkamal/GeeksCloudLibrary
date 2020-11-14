using Geeks.Cloud.Infrastructure.Management.Providers;

namespace Geeks.Cloud.Infrastructure.Management
{
    public interface IInfrastructureBuilder<C> where C : ICloudProvider
    {
        C BuildInfrastructure(C cloudProvider, string infrastructureName);
    }
}
