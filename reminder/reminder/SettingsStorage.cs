using Newtonsoft.Json;
using System;
using System.IO;

namespace reminder
{
    public static class SettingsStorage
    {
        private static readonly string AppDataDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ReminderApp");

        private static readonly string FilePath = Path.Combine(AppDataDir, "settings.json");
        private static readonly string DefaultSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

        public static AppSettings Load()
        {
            if (!Directory.Exists(AppDataDir))
                Directory.CreateDirectory(AppDataDir);

            if (!File.Exists(FilePath) && File.Exists(DefaultSettingsPath))
            {
                File.Copy(DefaultSettingsPath, FilePath);
            }

            if (!File.Exists(FilePath))
                return new AppSettings();

            string json = File.ReadAllText(FilePath);

            if (string.IsNullOrWhiteSpace(json))
                return new AppSettings();

            return JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();
        }

        public static void Save(AppSettings settings)
        {
            if (!Directory.Exists(AppDataDir))
                Directory.CreateDirectory(AppDataDir);

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}
