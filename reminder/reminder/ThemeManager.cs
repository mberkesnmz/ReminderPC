using System;
using System.Windows.Forms;

namespace reminder
{
    public static class ThemeManager
    {
        public static Theme CurrentTheme { get; private set; }

        public static void ApplyTheme(string themeName)
        {
            CurrentTheme = Themes.GetByName(themeName);

            ApplyThemeToAllForms(CurrentTheme);

            // Ayarları kaydet
            var settings = SettingsStorage.Load();
            settings.SelectedThemeName = themeName;
            settings.NotificationSoundPath = settings.NotificationSoundPath ?? "notification.wav"; // Eğer null ise default ses
            SettingsStorage.Save(settings);
        }

        public static void ApplyThemeToAllForms(Theme theme)
        {
            foreach (Form form in Application.OpenForms)
            {
                ThemeHelper.ApplyTheme(form, theme, skipThemeButtons: true);
            }
        }
    }
}