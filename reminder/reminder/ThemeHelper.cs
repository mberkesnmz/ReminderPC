using Guna.UI2.WinForms;
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

            // Simgeleri güncelle
            var settingsIcon = form.Controls.Find("settingsbutton", true).FirstOrDefault();
            if (settingsIcon is Guna2Button settingsBtn && File.Exists(theme.SettingsIconPath))
            {
                settingsBtn.Image = Image.FromFile(theme.SettingsIconPath);
            }

            var checkmarkIcon = form.Controls.Find("completedsbutton", true).FirstOrDefault();
            if (checkmarkIcon is Guna2Button checkBtn && File.Exists(theme.CheckmarkIconPath))
            {
                checkBtn.Image = Image.FromFile(theme.CheckmarkIconPath);
            }
        }

        public static void ApplyThemeToControl(Control ctrl, Theme theme, bool skipThemeButtons = false)
        {
            if (ctrl.Tag?.ToString() == "no_theme") return;

            // Bu kontrol eksikti, eklenmeli:
            if (skipThemeButtons && ctrl is Guna2GradientCircleButton btn && btn.Tag?.ToString() == "theme_button")
                return;

            ctrl.BackColor = theme.BackgroundColor;
            ctrl.ForeColor = theme.ForegroundColor;


            if (ctrl is Guna2Panel panel)
            {
                panel.FillColor = theme.PanelBackColor;
            }
            else if (ctrl is Guna2CircleProgressBar progressBar)
            {
                progressBar.ProgressColor = theme.PrimaryColor;
                progressBar.ProgressColor2 = theme.SecondaryColor;

            }
            else if (ctrl is Guna2GradientButton gradientbutton)
            {
                gradientbutton.FillColor = theme.PrimaryColor;
                gradientbutton.FillColor2 = theme.SecondaryColor;
                gradientbutton.ForeColor= theme.GradientButtonColor;

            }
            else if (ctrl is Label label)
            {
                if (label.Parent is Guna2Panel)
                    label.ForeColor = theme.PanelTextColor;
                else
                    label.ForeColor = theme.ForegroundColor;

                label.BackColor = Color.Transparent;
            }
            else if(ctrl is Guna2DateTimePicker datetimepick)
            {
                datetimepick.ForeColor = theme.PanelTextColor;
                datetimepick.FillColor = theme.PanelBackColor;
                datetimepick.FocusedColor = Color.Transparent;
                datetimepick.HoverState.FillColor = theme.PanelBackColor;
            }
            // Diğer Guna2 kontroller için istersen ekle

            // Alt kontrolleri de uygula (REKÜRSİF!)
            foreach (Control child in ctrl.Controls)
            {
                ApplyThemeToControl(child, theme, skipThemeButtons);
            }
        }

    }
}
