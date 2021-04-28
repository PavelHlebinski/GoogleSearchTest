using System.IO;
using System.Reflection;
using System.Text.Json;

namespace GoogleSearchTest.Settings
{
    public class AppSettings
    {
        public string Browser { get; set; }

        public string URL { get; set; }

        public static AppSettings ReadSettings()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "GoogleSearchTest.appsettings.json";

            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new StreamReader(stream);
            string result = reader.ReadToEnd();
            return JsonSerializer.Deserialize<AppSettings>(result);
        }
    }
}
