namespace Geeks.Cloud.Infrastructure.Management.ResourceTypes
{
    public class WindowsVirtualMachineType : IVirtualMachineType
    {
        string IResourceType.ResourceName => "Windows";
    }
}