using Geeks.Cloud.Infrastructure.Management.Providers;
using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management
{
    public interface IInfrastructureDelete<C> where C : ICloudProvider
    {
        Task<bool> DeleteInfrastructure(C c, string infrastructureName);
    }
}
