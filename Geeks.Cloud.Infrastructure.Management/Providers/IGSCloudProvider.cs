using System.IO;

namespace Geeks.Cloud.Infrastructure.Management.Providers
{
    public class IGSCloudProvider : ICloudProvider
    {
        #region Public Members

        public string Name { get => "IGS"; }

        public Infrastructure infrastructure;

        #endregion

        #region Private Members

        private string infrastructureName;

        #endregion

        public Infrastructure CreateInfrastructure(string infrastructureName)
        {
            infrastructure = new Infrastructure(infrastructureName);

            if (!Directory.Exists(Name))
            {
                Directory.CreateDirectory(Name);
            }

            if (!Directory.Exists($@"{Name}\{infrastructureName}"))
            {
                Directory.CreateDirectory($@"{Name}\{infrastructureName}");
            }

            this.infrastructureName = infrastructureName;

            return infrastructure;
        }

        public void BuildResources()
        {
            if (infrastructure?.resourceTypes != null && !string.IsNullOrEmpty(infrastructureName))
            {
                foreach (var resourceType in infrastructure.resourceTypes)
                {
                    if (!Directory.Exists($@"{Name}\{infrastructureName}\{resourceType.ResourceName}"))
                    {
                        Directory.CreateDirectory($@"{Name}\{infrastructureName}\{resourceType.ResourceName}");
                    }
                }
            }
        }
    }
}
