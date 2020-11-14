using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management
{
    public interface IInfrastructureBuilder<T>
    {
        Task<T> BuildInfrastructure();
    }
}
