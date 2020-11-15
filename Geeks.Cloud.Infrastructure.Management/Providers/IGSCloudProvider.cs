using Geeks.Cloud.Infrastructure.Helpers.Directory;
using Newtonsoft.Json;
using System;
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

            DirectoryHelper.CreateDirectoryIfNotExists(Name);

            DirectoryHelper.CreateDirectoryIfNotExists($@"{Name}\{infrastructureName}");

            this.infrastructureName = infrastructureName;

            return infrastructure;
        }

        public void BuildResources()
        {
            if (infrastructure?.resourceTypes != null && !string.IsNullOrEmpty(infrastructureName))
            {
                foreach (var resourceType in infrastructure.resourceTypes)
                {
                    DirectoryHelper.CreateDirectoryIfNotExists($@"{Name}\{infrastructureName}\{resourceType.ResourceName}");

                    var resourceObject = new
                    {
                        resourceType.ResourceName
                    };

                    var resourceObjectAsJson = JsonConvert.SerializeObject(resourceObject);

                    try
                    {
                        File.WriteAllText($@"{Name}\{infrastructureName}\{resourceType.ResourceName}\{infrastructureName}_Server.json", resourceObjectAsJson);
                    }
                    catch (System.Exception ex)
                    {
                        // Log Exception Message

                        // Throw Expection
                        throw ex;
                    }
                }
            }
        }

        public bool DeleteInfrastructure(string infrastructureName)
        {
            if (!Directory.Exists(Name))
            {
                throw new Exception("Cloud Provider Directory Not Found");
            }

            if (!Directory.Exists($@"{Name}\{infrastructureName}"))
            {
                throw new Exception("Infrastructure Directory Not Found");
            }

            foreach (var resourceDirectory in Directory.GetDirectories($@"{Name}\{infrastructureName}"))
            {
                try
                {
                    Directory.Delete(resourceDirectory, true);
                }
                catch (Exception ex)
                {
                    // Log ex.Message

                    throw ex;
                }
            }

            return true;
        }
    }
}
