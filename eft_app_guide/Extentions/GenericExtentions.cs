using System.Text.Json;

namespace eft_app_guide.Extentions
{
    public static class GenericExtentions
    {
        public static T? ToEntity<T>(this string? json) =>
            string.IsNullOrEmpty(json) ? throw new Exception() : JsonSerializer.Deserialize<T>(json);
    }
}
