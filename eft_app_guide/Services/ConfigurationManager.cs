using eft_app_guide.Models._Internal;
using System.IO;
using System.Text.Json;


namespace eft_app_guide.Services
{
    public static class ConfigurationManager
    {
        private readonly static string FILE_PATH = Path.Combine(App.ROOT_DATA_FOLDER, "config.json");

        public static SystemConfiguration Read()
        {
            if (!File.Exists(FILE_PATH))
            {
                using (File.Create(FILE_PATH)) { }
                Save(new());
                return new();
            }

            string? json = File.ReadAllText(FILE_PATH);
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
            File.WriteAllText(FILE_PATH, json);
        }

        public static void Update(Action<SystemConfiguration> updateAction)
        {
            SystemConfiguration config = Read();
            updateAction(config);
            Save(config);
        }
    }
}
