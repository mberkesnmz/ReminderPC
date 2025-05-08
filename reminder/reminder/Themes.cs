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
            PrimaryColor = Color.FromArgb(65, 65, 65), // siyah 
            SecondaryColor = Color.FromArgb(255, 0, 0), // açık kırmızı
            BackgroundColor = Color.FromArgb(37, 37, 37), // siyah
            ForegroundColor = Color.FromArgb(255, 0, 0), // hafif gri beyaz
            PanelBackColor = Color.FromArgb(175, 4, 4), // koyu kırmızı
            PanelTextColor = Color.FromArgb(37, 37, 37), // siyah   
            GradientButtonColor = Color.FromArgb(37, 37, 37), // siyah
            SettingsIconPath = "icons/red_dark/settings.png",
            CheckmarkIconPath = "icons/red_dark/checkmark.png",

        };

        public static Theme GreenDark => new Theme
        {
            PrimaryColor = Color.FromArgb(39, 70, 19), // koyu y
            SecondaryColor = Color.FromArgb(39, 57, 28), // açık yeşil
            BackgroundColor = Color.FromArgb(14, 30, 4),
            ForegroundColor = Color.FromArgb(39, 70, 19), // koyu y
            SettingsIconPath = "icons/green_dark/settings.png",
            CheckmarkIconPath = "icons/green_dark/checkmark.png",
            PanelBackColor = Color.FromArgb(39, 70, 19), // koyu y
            PanelTextColor = Color.Black,
            GradientButtonColor = Color.Black
        };

        public static Theme GreenLight => new Theme
        {
            PrimaryColor = Color.FromArgb(160, 200, 120),//yeşil
            SecondaryColor = Color.FromArgb(221, 235, 157), // açık yeşil
            BackgroundColor = Color.FromArgb(255, 253, 246), // açık beyaz
            ForegroundColor = Color.FromArgb(160, 200, 120), //yeşil
            SettingsIconPath = "icons/green_light/settings.png",
            CheckmarkIconPath = "icons/green_light/checkmark.png",
            PanelBackColor = Color.FromArgb(250, 246, 233), //krem
            PanelTextColor = Color.FromArgb(160, 200, 120), //yeşil
            GradientButtonColor = Color.FromArgb(255, 253, 246) // açık beyaz
        };

        public static Theme BlueLight => new Theme
        {
            PrimaryColor = Color.FromArgb(118, 159, 205), //mavi
            SecondaryColor = Color.FromArgb(185, 215, 234), //açık mavi
            BackgroundColor = Color.FromArgb(247, 251, 252), //açık beyaz
            ForegroundColor = Color.FromArgb(118, 159, 205), //mavi
            SettingsIconPath = "icons/blue_light/settings.png",
            CheckmarkIconPath = "icons/blue_light/checkmark.png",
            PanelBackColor = Color.FromArgb(214, 230, 242), //açık açık mavi
            PanelTextColor = Color.FromArgb(118, 159, 205), //mavi
            GradientButtonColor = Color.FromArgb(247, 251, 252), //açık beyaz
        };

        public static Theme PurpleLight => new Theme
        {
            PrimaryColor = Color.FromArgb(189, 131, 206), //mor
            SecondaryColor = Color.FromArgb(229, 176, 234),
            BackgroundColor = Color.FromArgb(247, 232, 246), //açık beyaz pembe
            ForegroundColor = Color.FromArgb(189, 131, 206), //mor
            SettingsIconPath = "icons/purple_light/settings.png",
            CheckmarkIconPath = "icons/purple_light/checkmark.png",
            PanelBackColor = Color.FromArgb(189, 131, 206), //mor
            PanelTextColor = Color.FromArgb(247, 232, 246), //açık beyaz pembe
            GradientButtonColor = Color.FromArgb(247, 251, 252) //açık beyaz
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
