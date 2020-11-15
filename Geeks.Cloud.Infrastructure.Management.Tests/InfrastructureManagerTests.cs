using Geeks.Cloud.Infrastructure.Management.Providers;
using NUnit.Framework;

namespace Geeks.Cloud.Infrastructure.Management.Tests
{
    public class InfrastructureManagerTests
    {
        private InfrastructureManager _infrastructureManager;

        [SetUp]
        public void Setup()
        {
            _infrastructureManager = new InfrastructureManager();
        }

        [Test]
        public void BuildInfrastructure_ShouldCreateSubdirectoryForEachResource()
        {
            IGSCloudProvider iGSCloudProvider = new IGSCloudProvider();

            _infrastructureManager.BuildInfrastructure(iGSCloudProvider, "Test");
        }

        [Test]
        public void DeleteInfrastructure_ShouldDeleteAllSubdirectoriesUnderInfrastructure()
        {
            IGSCloudProvider iGSCloudProvider = new IGSCloudProvider();

            _infrastructureManager.DeleteInfrastructure(iGSCloudProvider, "Test");
        }
    }
}