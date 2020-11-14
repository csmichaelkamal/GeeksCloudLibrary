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
        public void BuildInfrastructure_ShouldCreateWindows()
        {
            IGSCloudProvider iGSCloudProvider = new IGSCloudProvider();

            _infrastructureManager.BuildInfrastructure(iGSCloudProvider, "UAT");
        }
    }
}