namespace Geeks.Cloud.Infrastructure.Management
{
    interface IInfrastructureManager<T> : IInfrastructureBuilder<T>, IInfrastructureDelete<T>
    {

    }
}
