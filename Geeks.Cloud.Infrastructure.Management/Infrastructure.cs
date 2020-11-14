using Geeks.Cloud.Infrastructure.Management.ResourceTypes;
using System.Collections.Generic;

namespace Geeks.Cloud.Infrastructure.Management
{
    public class Infrastructure
    {
        private readonly string _name;

        public List<IResourceType> resourceTypes = new List<IResourceType>();

        public Infrastructure(string name)
        {
            _name = name;
        }

        public Infrastructure AddVirtualMachine(IVirtualMachineType virtualMachineType)
        {
            var virtualMachine = new VirtualMachine(virtualMachineType);
            resourceTypes.Add(virtualMachine);
            return this;
        }

        public Infrastructure AddDatabase(IDatabaseType databaseType)
        {
            var database = new Database(databaseType);
            resourceTypes.Add(database);
            return this;
        }
    }
}
