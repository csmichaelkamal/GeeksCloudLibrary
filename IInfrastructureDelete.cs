using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management
{
    public interface IInfrastructureDelete<T>
    {
        Task<bool> DeleteInfrastructure(T t);
    }
}
