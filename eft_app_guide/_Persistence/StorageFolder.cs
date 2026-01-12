using eft_app_guide.Models._Internal;
using System.IO;
using System.Text.Json;

namespace eft_app_guide._Persistence
{
    public static class StorageFolder
    {
        public readonly static string ROOT_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EFT GUIDE");
        public readonly static string ASSET_FOLDER = Path.Combine(ROOT_FOLDER, "Assets");
        public readonly static string DATA_FOLDER = Path.Combine(ROOT_FOLDER, "Data");

        /// <summary>
        /// Holds SystemConfigurations data
        /// </summary>
        public readonly static string CONFIG_FILE = Path.Combine(DATA_FOLDER, "config.json");

        public readonly static string PROFILES_FILE = Path.Combine(DATA_FOLDER, "profiles.json");

        public static void CreateDirectory()
        {
            Directory.CreateDirectory(ROOT_FOLDER);
            Directory.CreateDirectory(ASSET_FOLDER);
            Directory.CreateDirectory(DATA_FOLDER);
        }

        public static void EnsureConfigFile()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                File.Create(CONFIG_FILE);
                string json = JsonSerializer.Serialize(new SystemConfiguration(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(CONFIG_FILE, json);
            }
        }
    }
}
