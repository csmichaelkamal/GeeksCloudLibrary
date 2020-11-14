namespace Geeks.Cloud.Infrastructure.Management.ResourceTypes
{
    public class VirtualMachine : IResourceType
    {
        private readonly IVirtualMachineType _virtualMachineType;

        public VirtualMachine(IVirtualMachineType virtualMachineType)
        {
            _virtualMachineType = virtualMachineType;
        }

        public string ResourceName => "VirtualMachine";
    }
}
