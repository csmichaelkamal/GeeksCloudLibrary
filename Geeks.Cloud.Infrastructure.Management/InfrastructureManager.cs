using Geeks.Cloud.Infrastructure.Management.Providers;
using Geeks.Cloud.Infrastructure.Management.ResourceTypes;
using System;
using System.Threading.Tasks;

namespace Geeks.Cloud.Infrastructure.Management
{
    public class InfrastructureManager : IInfrastructureManager<IGSCloudProvider>
    {
        public IGSCloudProvider BuildInfrastructure(IGSCloudProvider iGSCloudProvider, string infrastructureName)
        {
            var windowsVirtualMachine = new WindowsVirtualMachineType();
            var mySQLDatabase = new MySQLDatabaseType();

            iGSCloudProvider.CreateInfrastructure(infrastructureName)
                .AddVirtualMachine(windowsVirtualMachine)
                .AddDatabase(mySQLDatabase);

            iGSCloudProvider.BuildResources();

            return iGSCloudProvider;
        }

        public Task<bool> DeleteInfrastructure(IGSCloudProvider iGSCloudProvider, string infrastructureName)
        {
            var infrastructureDeleted = iGSCloudProvider.DeleteInfrastructure(infrastructureName);

            return Task.FromResult(infrastructureDeleted);
        }
    }
}
