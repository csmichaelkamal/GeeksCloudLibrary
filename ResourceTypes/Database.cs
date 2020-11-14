namespace Geeks.Cloud.Infrastructure.Management.ResourceTypes
{
    public class Database : IResourceType
    {
        private readonly IDatabaseType _databaseType;

        public Database(IDatabaseType databaseType)
        {
            _databaseType = databaseType;
        }

        public string ResourceName => "Database";
    }
}
