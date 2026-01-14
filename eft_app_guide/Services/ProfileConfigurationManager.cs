using eft_app_guide._Persistence;
using eft_app_guide.DataTransferObjects;
using System.IO;
using System.Text.Json;

namespace eft_app_guide.Services
{
    public static class ProfileConfigurationManager
    {
        private static void EnsureFileExists()
        {
            if (!File.Exists(StorageFolder.PROFILES_FILE))
            {
                File.Create(StorageFolder.PROFILES_FILE).Dispose();
                string json = JsonSerializer.Serialize(new ProfileConfiguration(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(StorageFolder.PROFILES_FILE, json);
            }
        }

        public static ProfileConfiguration Read()
        {
            EnsureFileExists();

            string? json = File.ReadAllText(StorageFolder.CONFIG_FILE);
            if (string.IsNullOrEmpty(json)) return new();

            try
            {
                ProfileConfiguration config = JsonSerializer.Deserialize<ProfileConfiguration>(json)!;
                return config;
            }
            catch (JsonException e) { throw new JsonException("Could not convert json to ProfileConfiguration.", e); }
        }

        public static T GetValue<T>(Func<ProfileConfiguration, T> selector) => selector(Read());

        public static void Save(ProfileConfiguration config)
        {
            EnsureFileExists();

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(StorageFolder.CONFIG_FILE, json);
        }

        public static void Update(Action<ProfileConfiguration> updateAction)
        {
            ProfileConfiguration config = Read();
            updateAction(config);
            Save(config);
        }
    }
}
