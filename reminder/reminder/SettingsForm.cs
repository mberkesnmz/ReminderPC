using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Guna.UI2.WinForms;

namespace reminder
{

    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Mevcut tema ayarını yükle
            var settings = SettingsStorage.Load();
            string selectedThemeName = settings?.SelectedThemeName ?? "green_light";
            Theme themeToApply = Themes.GetByName(selectedThemeName);

            // Temayı uygula, tema butonlarını atla
            ThemeHelper.ApplyTheme(this, themeToApply, skipThemeButtons: true);

            // Tema butonlarını oluştur ve ekle
            flowLayoutPanelThemes.Controls.Clear(); // Eski butonları temizle

            var themeButtons = new[]
            {
                CreateThemeButton(Color.FromArgb(160, 200, 120), Color.FromArgb(221, 235, 157), "green_light"),
                CreateThemeButton(Color.DeepSkyBlue, Color.LightBlue, "blue_light"),
                CreateThemeButton(Color.MediumPurple, Color.Plum, "purple_light"),
                CreateThemeButton(Color.FromArgb(139, 0, 0), Color.DarkRed, "red_dark"),
                CreateThemeButton(Color.Black, Color.MidnightBlue, "green_dark")
            };

            foreach (var btn in themeButtons)
            {
                btn.Tag = "theme_button"; // Tema butonu olduğunu işaretle
                flowLayoutPanelThemes.Controls.Add(btn);
            }
        }



        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Guna2GradientCircleButton CreateThemeButton(Color color1, Color color2, string tag)
        {
            var btn = new Guna2GradientCircleButton
            {
                Width = 40,
                Height = 40,
                FillColor = color1,
                FillColor2 = color2,
                Tag = tag,
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };
            btn.Tag = "theme_button";
            btn.Click += ThemeButton_Click;
            return btn;
        }
        private void ThemeButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2GradientCircleButton;
            string themeName = btn.Tag.ToString(); // Butonun tag'ine göre tema seçimi

            // Tema değişimini yap
            Theme selectedTheme = Themes.GetByName(themeName);
            ThemeManager.ApplyThemeToAllForms(selectedTheme);

            // Seçilen butona görsel değişiklik ekleyelim
            foreach (var button in flowLayoutPanelThemes.Controls)
            {
                var themeButton = button as Guna2GradientCircleButton;
                if (themeButton != null)
                {
                    themeButton.FillColor = themeButton.Tag.ToString() == themeName
                        ? Color.FromArgb(255, 255, 255)  // Seçilen butonun rengini değiştirebilirsiniz.
                        : Color.FromArgb(160, 200, 120); // Diğer butonları eski renge döndürelim
                }
            }

            // Temayı kaydedelim
            SettingsStorage.Save(new AppSettings { SelectedThemeName = themeName });
        }

    }
}
