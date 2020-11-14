using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management
{
    public interface IInfrastructureDelete
    {
        Task<bool> DeleteInfrastructure();
    }
}
