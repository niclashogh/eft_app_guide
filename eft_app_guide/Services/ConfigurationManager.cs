using eft_app_guide._Persistence;
using eft_app_guide.Models._Internal;
using System.IO;
using System.Text.Json;


namespace eft_app_guide.Services
{
    public static class ConfigurationManager
    {
        public static SystemConfiguration Read()
        {
            StorageFolder.EnsureConfigFile();

            string? json = File.ReadAllText(StorageFolder.CONFIG_FILE);
            if (string.IsNullOrEmpty(json)) return new();

            try
            {
                SystemConfiguration config = JsonSerializer.Deserialize<SystemConfiguration>(json)!;
                return config;
            }
            catch(JsonException e) { throw new JsonException("Could not convert json to SystemConfiguration.", e); }
        }

        public static T GetValue<T>(Func<SystemConfiguration, T> selector) => selector(Read());

        public static void Save(SystemConfiguration config)
        {
            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(StorageFolder.CONFIG_FILE, json);
        }

        public static void Update(Action<SystemConfiguration> updateAction)
        {
            SystemConfiguration config = Read();
            updateAction(config);
            Save(config);
        }
    }
}
