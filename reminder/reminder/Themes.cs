using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reminder
{

    public static class Themes
    {
        public static Theme RedDark => new Theme
        {
            PrimaryColor = Color.Black,
            SecondaryColor = Color.DarkRed,
            BackgroundColor = Color.FromArgb(20, 20, 20),
            ForegroundColor = Color.White,
            SettingsIconPath = "icons/red_dark/settings.png",
            CheckmarkIconPath = "icons/red_dark/checkmark.png"
        };

        public static Theme GreenDark => new Theme
        {
            PrimaryColor = Color.Black,
            SecondaryColor = Color.ForestGreen,
            BackgroundColor = Color.FromArgb(20, 20, 20),
            ForegroundColor = Color.White,
            SettingsIconPath = "icons/green_dark/settings.png",
            CheckmarkIconPath = "icons/green_dark/checkmark.png"
        };

        public static Theme GreenLight => new Theme
        {
            PrimaryColor = Color.FromArgb(160, 200, 120),
            SecondaryColor = Color.FromArgb(221, 235, 157),
            BackgroundColor = Color.White,
            ForegroundColor = Color.Black,
            SettingsIconPath = "icons/green_light/settings.png",
            CheckmarkIconPath = "icons/green_light/checkmark.png"
        };

        public static Theme BlueLight => new Theme
        {
            PrimaryColor = Color.DeepSkyBlue,
            SecondaryColor = Color.LightBlue,
            BackgroundColor = Color.White,
            ForegroundColor = Color.Black,
            SettingsIconPath = "icons/blue_light/settings.png",
            CheckmarkIconPath = "icons/blue_light/checkmark.png"
        };

        public static Theme PurpleLight => new Theme
        {
            PrimaryColor = Color.MediumPurple,
            SecondaryColor = Color.Plum,
            BackgroundColor = Color.White,
            ForegroundColor = Color.Black,
            SettingsIconPath = "icons/purple_light/settings.png",
            CheckmarkIconPath = "icons/purple_light/checkmark.png"
        };

        public static Theme GetByName(string name)
        {
            if (name == "green_light") return GreenLight;
            if (name == "blue_light") return BlueLight;
            if (name == "purple_light") return PurpleLight;
            if (name == "red_dark") return RedDark;
            if (name == "green_dark") return GreenDark;

            return GreenLight; // varsayılan tema
        }
    }


}
