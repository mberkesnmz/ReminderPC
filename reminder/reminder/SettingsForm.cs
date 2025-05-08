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
using System.IO;

namespace reminder
{

    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            LoadCurrentSettings();
            UpdateNotificationLabel();
        }

        private void LoadCurrentSettings()
        {
            // Ayarları yükle
            var settings = SettingsStorage.Load();

            // Seçilen ses dosyasını yükle ve butonun yanında göster
            if (!string.IsNullOrEmpty(settings.NotificationSoundPath) && settings.NotificationSoundPath != "notification.wav")
            {
                lblNotificationSound.Text = Path.GetFileName(settings.NotificationSoundPath);
            }
            else
            {
                lblNotificationSound.Text = "notification.wav (Default)";
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var settings = SettingsStorage.Load();
            string selectedThemeName = settings?.SelectedThemeName ?? "green_light";
            Theme selectedTheme = Themes.GetByName(selectedThemeName);

            ThemeManager.ApplyTheme(selectedThemeName);

            flowLayoutPanelThemes.Controls.Clear();

            var themeButtons = new[]
            {
                CreateThemeButton(Color.White, Color.LightGreen, "green_light"),
                CreateThemeButton(Color.White, Color.LightBlue, "blue_light"),
                CreateThemeButton(Color.White, Color.Pink, "purple_light"),
                CreateThemeButton(Color.Black, Color.DarkRed, "red_dark"),
                CreateThemeButton(Color.Black, Color.DarkGreen, "green_dark")
            };

            foreach (var btn in themeButtons)
            {
                btn.AccessibleName = btn.Name = btn.Tag.ToString();
                btn.Click += ThemeButton_Click;

                if (btn.AccessibleName == selectedThemeName)
                {
                    btn.BorderThickness = 3;

                    int avgColor = (btn.FillColor.R + btn.FillColor.G + btn.FillColor.B) / 3;
                    btn.BorderColor = avgColor > 180 ? Color.Black : Color.White;

                    btn.Width = btn.Height = 70; // Seçili buton daha büyük
                }
                else
                {
                    btn.BorderThickness = 0;
                    btn.Width = btn.Height = 55; // Normal boyut
                }

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
                Width = 50,
                Height = 50,
                FillColor = color1,
                FillColor2 = color2,
                Tag = tag,
                Margin = new Padding(10),
                Cursor = Cursors.Hand
            };
            
            btn.Click += ThemeButton_Click;
            return btn;
        }
        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2GradientCircleButton btn)
            {
                string themeName = btn.Tag.ToString();

                ThemeManager.ApplyTheme(themeName);

                ThemeHelper.ApplyTheme(this, ThemeManager.CurrentTheme, skipThemeButtons: true);

                foreach (var button in flowLayoutPanelThemes.Controls.OfType<Guna2GradientCircleButton>())
                {
                    if (button == btn)
                    {
                        button.BorderThickness = 3;

                        int avgColor = (button.FillColor.R + button.FillColor.G + button.FillColor.B) / 3;
                        button.BorderColor = avgColor > 180 ? Color.Black : Color.White;

                        // Seçili butonu büyüt
                        button.Width = button.Height = 70; // Normalden biraz büyük
                    }
                    else
                    {
                        button.BorderThickness = 0;
                        button.Width = button.Height = 55; // Normal boyut
                    }
                }
            }
        }

        private void closebutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeNotificationSound_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV Files (*.wav)|*.wav|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a Notification Sound";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;

                    if (!string.IsNullOrEmpty(selectedPath) && File.Exists(selectedPath))
                    {
                        // Ayarları yükle
                        var settings = SettingsStorage.Load();

                        // Seçilen dosya yolunu ayarlara yaz
                        settings.NotificationSoundPath = selectedPath;

                        // Ayarları kaydet
                        SettingsStorage.Save(settings);

                        // Label'ı güncelle
                        UpdateNotificationLabel();
                    }
                    else
                    {
                        MessageBox.Show("Seçilen dosya geçersiz.");
                    }
                }
            }
        }

        private void btnUseDefaultSound_Click(object sender, EventArgs e)
        {
            // Varsayılan ses yolunu kaydet
            var settings = SettingsStorage.Load();
            settings.NotificationSoundPath = "notification.wav"; // Varsayılan ses
            SettingsStorage.Save(settings);

            // Etiketi güncelle
            lblNotificationSound.Text = "notification.wav (Default)";
        }

        private void UpdateNotificationLabel()
        {
            var settings = SettingsStorage.Load();
            string soundPath = settings?.NotificationSoundPath;

            if (string.IsNullOrWhiteSpace(soundPath))
            {
                lblNotificationSound.Text = "notification.wav (Default)";
                return;
            }

            string fileName = Path.GetFileName(soundPath);

            if (fileName.Length > 35)
                fileName = fileName.Substring(0, 35) + "...";

            lblNotificationSound.Text = fileName;
        }
    }
}
