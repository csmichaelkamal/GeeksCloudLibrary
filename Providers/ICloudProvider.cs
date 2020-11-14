using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management.Providers
{
    public interface ICloudProvider
    {
        string Name { get; }

        Infrastructure CreateInfrastructure(string infrastructureName);
    }
}
