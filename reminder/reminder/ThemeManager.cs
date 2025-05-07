using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using reminder;

public static class ThemeManager
{
    public static Theme CurrentTheme { get; private set; }

    public static void ApplyTheme(string themeName)
    {
        switch (themeName.ToLower())
        {
            case "red_dark":
                CurrentTheme = Themes.RedDark;
                break;
            case "green_dark":
                CurrentTheme = Themes.GreenDark;
                break;
            case "green_light":
                CurrentTheme = Themes.GreenLight;
                break;
            case "blue_light":
                CurrentTheme = Themes.BlueLight;
                break;
            case "purple_light":
                CurrentTheme = Themes.PurpleLight;
                break;
            default:
                CurrentTheme = Themes.GreenLight; // Varsayılan tema
                break;
        }

        ApplyThemeToAllForms(CurrentTheme);
    }

    public static void ApplyThemeToAllForms(Theme theme)
    {
        foreach (Form form in Application.OpenForms)
        {
            ApplyThemeToForm(form, theme);
        }
    }

    public static void ApplyThemeToForm(Form form, Theme theme)
    {
        form.BackColor = theme.BackgroundColor;
        form.ForeColor = theme.ForegroundColor;

        foreach (Control control in form.Controls)
        {
            ApplyThemeToControl(control, theme);
        }

        // Örnek: ikonları değiştir
        var settingsIcon = form.Controls.Find("settingsIcon", true).FirstOrDefault() as PictureBox;
        if (settingsIcon != null && System.IO.File.Exists(theme.SettingsIconPath))
        {
            settingsIcon.Image = Image.FromFile(theme.SettingsIconPath);
        }

        var checkIcon = form.Controls.Find("checkmarkIcon", true).FirstOrDefault() as PictureBox;
        if (checkIcon != null && System.IO.File.Exists(theme.CheckmarkIconPath))
        {
            checkIcon.Image = Image.FromFile(theme.CheckmarkIconPath);
        }
    }

    private static void ApplyThemeToControl(Control control, Theme theme)
    {
        if (control is Guna2GradientButton gradientButton)
        {
            gradientButton.FillColor = theme.PrimaryColor;
            gradientButton.FillColor2 = theme.SecondaryColor;
            gradientButton.ForeColor = theme.ForegroundColor;
        }

        if (control is Guna2GradientCircleButton gradientCircleButton)
        {
            gradientCircleButton.FillColor = theme.PrimaryColor;
            gradientCircleButton.FillColor2 = theme.SecondaryColor;
        }

        // Diğer kontrolleri yinele
        foreach (Control child in control.Controls)
        {
            ApplyThemeToControl(child, theme);
        }
    }
}
