namespace Geeks.Cloud.Infrastructure.Helpers.Directory
{
    using System.IO;

    public class DirectoryHelper
    {
        public static void CreateDirectoryIfNotExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }
    }
}
