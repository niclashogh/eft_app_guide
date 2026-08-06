using eft_app_guide._Persistence;
using System.IO;
using System.Text.Json;

namespace eft_app_guide.Services
{
    public static class JsonStorage
    {
        private static void EnsureFileExists<T>(string path)
        {
            if (!File.Exists(path))
            {
                string json = JsonSerializer.Serialize(Activator.CreateInstance<T>(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);
            }
        }

        private static string GetPath<T>() => Path.Combine(StorageDirectory.DATA_FOLDER, $"{typeof(T).Name}.json");

        public static T Read<T>()
        {
            string path = GetPath<T>();
            EnsureFileExists<T>(path);

            try
            {
                string? json = File.ReadAllText(path);
                T config = JsonSerializer.Deserialize<T>(json) ?? Activator.CreateInstance<T>();
                return config;
            }
            catch (JsonException e) { throw new JsonException($"Could not convert {typeof(T).Name}.", e); }
        }

        public static void Save<T>(T config)
        {
            string path = GetPath<T>();

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static void Update<T>(Action<T> updateAction)
        {
            T config = Read<T>();
            updateAction(config);
            Save(config);
        }

        public static TValue Select<TClass, TValue>(Func<TClass, TValue> selector) => selector(Read<TClass>());
    }
}
