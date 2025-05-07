using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace reminder
{
    public static class ThemeHelper
    {
        public static void ApplyTheme(Form form, Theme theme, bool skipThemeButtons = false)
        {
            form.BackColor = theme.BackgroundColor;
            form.ForeColor = theme.ForegroundColor;

            foreach (Control ctrl in form.Controls)
            {
                ApplyThemeToControl(ctrl, theme, skipThemeButtons);
            }

            var settingsIcon = form.Controls.Find("picSettings", true).FirstOrDefault() as PictureBox;
            var checkmarkIcon = form.Controls.Find("picCheckmark", true).FirstOrDefault() as PictureBox;

            if (settingsIcon != null && File.Exists(theme.SettingsIconPath))
                settingsIcon.Image = Image.FromFile(theme.SettingsIconPath);

            if (checkmarkIcon != null && File.Exists(theme.CheckmarkIconPath))
                checkmarkIcon.Image = Image.FromFile(theme.CheckmarkIconPath);
        }

        private static void ApplyThemeToControl(Control ctrl, Theme theme, bool skipThemeButtons)
        {
            if (skipThemeButtons && ctrl is Guna.UI2.WinForms.Guna2GradientCircleButton && ctrl.Tag?.ToString() == "theme_button")
                return;

            if (ctrl is Guna.UI2.WinForms.Guna2GradientButton gradientBtn)
            {
                gradientBtn.FillColor = theme.PrimaryColor;
                gradientBtn.FillColor2 = theme.SecondaryColor;
            }
            else if (ctrl is Guna.UI2.WinForms.Guna2Button normalBtn)
            {
                normalBtn.FillColor = theme.PrimaryColor;
                normalBtn.ForeColor = theme.ForegroundColor;
            }

            if (ctrl.HasChildren)
            {
                foreach (Control child in ctrl.Controls)
                {
                    ApplyThemeToControl(child, theme, skipThemeButtons);
                }
            }
        }
    }
}
