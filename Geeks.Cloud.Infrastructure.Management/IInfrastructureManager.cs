using Geeks.Cloud.Infrastructure.Management.Providers;

namespace Geeks.Cloud.Infrastructure.Management
{
    interface IInfrastructureManager<C> : IInfrastructureBuilder<C>, IInfrastructureDelete<C>
        where C : ICloudProvider
    {

    }
}
