using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reminder
{
    public static class SettingsStorage
    {
        private static readonly string FilePath = "settings.json";

        public static AppSettings Load()
        {

            if (!File.Exists(FilePath))
                return new AppSettings();

            string json = File.ReadAllText(FilePath);

            if (string.IsNullOrWhiteSpace(json))
                return new AppSettings(); // dosya boşsa da varsayılan ayarlar döndür

            return JsonConvert.DeserializeObject<AppSettings>(json);
        }

        public static void Save(AppSettings settings)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}
