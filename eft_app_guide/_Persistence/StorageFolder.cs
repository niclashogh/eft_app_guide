using System.IO;

namespace eft_app_guide._Persistence
{
    public static class StorageFolder
    {
        public readonly static string ROOT_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EFT GUIDE");
        public readonly static string ASSET_FOLDER = Path.Combine(ROOT_FOLDER, "Assets");
        public readonly static string DATA_FOLDER = Path.Combine(ROOT_FOLDER, "Data");

        /// <summary>
        /// Contains SystemConfigurations data
        /// </summary>
        public readonly static string CONFIG_FILE = Path.Combine(DATA_FOLDER, "config.json");

        public static void CreateDirectory()
        {
            Directory.CreateDirectory(ROOT_FOLDER);
            Directory.CreateDirectory(ASSET_FOLDER);
            Directory.CreateDirectory(DATA_FOLDER);
        }
    }
}
