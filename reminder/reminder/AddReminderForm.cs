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
using System.IO;

namespace reminder
{

    public partial class AddReminderForm : Form
    {
        private Label notificationLabel; // Bildirim etiketi
        private const int NotificationWidth = 22; // Genişlik arttı (çift basamak için)
        private const int NotificationHeight = 13; // Yükseklik sabit
        public AddReminderForm()
        {

            InitializeComponent();
            flowLayoutPanel1.SizeChanged += (s, e) => UpdatePanelWidths();

            InitializeNotificationLabel(); // Bildirim etiketini başlatıyoruz
            UpdateCompletedTasksCount(); // Tamamlanmış görev sayısını günceller

        }

        private void InitializeNotificationLabel()
        {
            // Bildirim etiketini oluşturuyoruz
            notificationLabel = new Label
            {
                Location = new Point(
                    completedsbutton.Location.X + completedsbutton.Width - NotificationWidth / 2,
                    completedsbutton.Location.Y - NotificationHeight / 2
                ),
                Size = new Size(NotificationWidth, NotificationHeight),  // Genişletilmiş boyut
                ForeColor = Color.White,  // Yazı rengi
                BackColor = Color.Red,  // Bildirim arka plan rengi
                TextAlign = ContentAlignment.MiddleCenter,  // Sayıyı ortala
                Text = "0",  // Başlangıç değeri
                Font = new Font("Arial", 7, FontStyle.Bold),  // Bir tık daha küçük font
                Visible = true,  // Görünür
                BorderStyle = BorderStyle.None,  // Kenarlık yok
                AutoSize = false, // Manuel boyut
               
                Tag= "no_theme"

        };

            // Etiketi formun kontrollerine ekliyoruz
            this.Controls.Add(notificationLabel);

            notificationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right ;
            completedsbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

        private void UpdateCompletedTasksCount()
        {
            List<Reminder> reminders = ReminderStorage.GetAll();
            int completedTaskCount = reminders.Count(r => r.IsCompleted);

            if (completedTaskCount == 0)
            {
                notificationLabel.Visible = false;
                return;
            }

            notificationLabel.Visible = true;

            // 99+ sınırı
            string countText = completedTaskCount > 99 ? "99+" : completedTaskCount.ToString();
            notificationLabel.Text = countText;

            // Genişliği metin uzunluğuna göre ayarla
            int width = countText.Length == 1 ? 13 : 20;

            // Yeni boyut ve konumu ayarla
            notificationLabel.Size = new Size(width, 13);
            notificationLabel.Location = new Point(
                completedsbutton.Location.X + completedsbutton.Width - width / 2,
                completedsbutton.Location.Y - 13 / 2
            );
        }



        private void UpdatePanelWidths()
        {
            int panelWidth = flowLayoutPanel1.ClientSize.Width - 20;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Panel panel)
                {
                    panel.Width = panelWidth;
                    // Eğer istersen: panel içindeki yerleşimleri de yeniden hizalayabilirsin
                }
            }
        }



        private void AddReminderForm_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////theme
            // Ayarlardan kayıtlı tema adını al
            var settings = SettingsStorage.Load();
            string themeName = settings.SelectedThemeName ?? "green_light"; // varsayılan tema

            // Tema adını kullanarak uygula
            ThemeManager.ApplyTheme(themeName);
            ////////////////////////////////////////////////theme

            var reminders = ReminderStorage.Load();
            foreach (var reminder in reminders.Where(r => !r.IsCompleted))
            {
                AddReminderToPanel(reminder);
            }

            ReminderStorage.UpdateCompletedReminders();



            reminderTimer.Interval = 5000; // her 5 saniyede bir kontrol et
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
            
        }


        private async void AnimateShake(Control panel)
        {
            var originalMargin = panel.Margin;

            for (int i = 0; i < 6; i++)
            {
                panel.Margin = new Padding(originalMargin.Left + 5, originalMargin.Top, originalMargin.Right - 5, originalMargin.Bottom);
                await Task.Delay(50);
                panel.Margin = new Padding(originalMargin.Left - 5, originalMargin.Top, originalMargin.Right + 5, originalMargin.Bottom);
                await Task.Delay(50);
            }

            panel.Margin = originalMargin;
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            var reminders = ReminderStorage.Load();
            var now = DateTime.Now;

            foreach (var panel in flowLayoutPanel1.Controls.OfType<Guna.UI2.WinForms.Guna2Panel>())
            {
                if (panel.Tag is Reminder reminder && !reminder.IsCompleted)
                {
                    // Zamanı gelmiş mi?
                    if (Math.Abs((reminder.DateTime - now).TotalMinutes) < 1)
                    {
                        panel.FillColor = Color.LightGreen;

                        PlayNotificationSound();
                        AnimateShake(panel);
                        // Bir kere çalışsın diye tamamlandı gibi işaretleyebiliriz
                        reminder.IsCompleted = true;
                        ReminderStorage.Update(reminder);
                    }
                }
            }
        }

        private void PlayNotificationSound()
        {
            try
            {
                var settings = SettingsStorage.Load();
                string soundPath = settings.NotificationSoundPath;
                if (string.IsNullOrEmpty(soundPath) || !File.Exists(soundPath))
                {
                    soundPath = "notification.wav";
                }

                using (SoundPlayer player = new SoundPlayer(soundPath))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses çalarken hata: " + ex.Message);
            }
        }

        public void AddReminderToPanel(Reminder reminder)
        {
            // Paneli oluşturuyoruz
            var panel = new Guna.UI2.WinForms.Guna2Panel
            {
                Width = flowLayoutPanel1.ClientSize.Width - 20, // FlowLayoutPanel'e göre genişlik
                BorderRadius = 20,
                FillColor = reminder.DateTime < DateTime.Now
                    ? Color.LightGreen
                    : Color.FromArgb(250, 246, 233),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                Tag = reminder,
                Margin = new Padding(10)
            };

            var lblTitle = new Label
            {
                Text = reminder.Title,
                Font = new Font("Open Sans", 14, FontStyle.Bold),
                AutoSize = true,
                MaximumSize = new Size(panel.Width - 140, 0),
                Height = 0, // Otomatik yükseklik için sonra ayarlanacak
                BackColor = Color.Transparent,
                Location = new Point(10, 10)
            };




            // Butonlar (başta görünmesin)
            var btnComplete = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "✓",
                Width = 30,
                Height = 30,
                FillColor = Color.LightGreen,
                Visible = false,
                Location = new Point(panel.Width - 70, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            var btnDelete = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "🗑",
                Width = 30,
                Height = 30,
                FillColor = Color.IndianRed,
                Visible = false,
                Location = new Point(panel.Width - 35, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            // Progress bar boyutları
            int progressSize = 60;
            int progressY = 10 + btnComplete.Height + 5; // Butonlardan sonra 5px boşluk

            var progress = new Guna.UI2.WinForms.Guna2CircleProgressBar
            {
                Name = "progress",
                Size = new Size(progressSize, progressSize),
                Location = new Point(
                    panel.Width - progressSize - 10, // Sağdan 10px içeride
                    progressY
                ),
                ProgressColor = Color.FromArgb(221, 235, 157),
                ProgressColor2 = Color.FromArgb(160, 200, 120),
                FillColor = Color.WhiteSmoke,
                BackColor = Color.Transparent,
                UseTransparentBackground = true,
                ShadowDecoration = { Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle },
                ShowPercentage = false,
                Value = CalculateProgress(reminder.DateTime),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            // Tarih
            var lblDate = new Label
            {
                Name = "lblDate",
                Text = reminder.DateTime.ToString("dd.MM.yyyy"),
                Font = new Font("Open Sans", 10, FontStyle.Bold),
                AutoSize = true,  // Otomatik boyutlandırma
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 200, 120),
                Location = new Point(10, panel.Height - 10)
            };

            // Saat
            var lblTime = new Label
            {
                Name = "lblTime",
                Text = reminder.DateTime.ToString("HH:mm"),
                Font = new Font("Open Sans", 10, FontStyle.Bold),
                AutoSize = true,  // Otomatik boyutlandırma
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 200, 120),
                Location = new Point(lblDate.Location.X + lblDate.PreferredWidth + 10, lblDate.Location.Y)
            };


            var lblRemaining = new Label
            {
                Text = GetTimeRemainingText(reminder.DateTime),
                Font = new Font("Open Sans", 9, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                BackColor = Color.Transparent,
                Location = new Point(lblTitle.Right + 5, lblTitle.Top) , // Başlık bitiminden 5px sonra
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };


            var lblDesc = new Label
            {
                Text = reminder.Description,
                Font = new Font("Open Sans", 10, FontStyle.Regular),
                AutoSize = true,
                BackColor = Color.Transparent,
                MaximumSize = new Size(panel.Width - progressSize - 20, 0),
                Location = new Point(10, Math.Max(lblTitle.Bottom, lblRemaining.Bottom) + 5)
            };

            btnComplete.Click += (s, e) =>
            {
                reminder.IsCompleted = true;
                panel.FillColor = Color.LightGreen;
                ReminderStorage.Update(reminder); // JSON güncelle
            };

            btnDelete.Click += (s, e) =>
            {
                flowLayoutPanel1.Controls.Remove(panel);
                ReminderStorage.Delete(reminder); // JSON'dan sil
            };

            // Hover eventleri
            panel.MouseEnter += (s, e) =>
            {
                btnComplete.Visible = true;
                btnDelete.Visible = true;
            };

            panel.MouseLeave += (s, e) =>
            {
                // Fare panel dışına çıkarsa gizle
                if (!btnComplete.Bounds.Contains(panel.PointToClient(Cursor.Position)) &&
                    !btnDelete.Bounds.Contains(panel.PointToClient(Cursor.Position)))
                {
                    btnComplete.Visible = false;
                    btnDelete.Visible = false;
                }
            };

            // Butonlara özel MouseEnter/Leave (gizlenmesin diye)
            btnComplete.MouseEnter += (s, e) => btnComplete.Visible = true;
            btnDelete.MouseEnter += (s, e) => btnDelete.Visible = true;
            btnComplete.MouseLeave += (s, e) => btnComplete.Visible = false;
            btnDelete.MouseLeave += (s, e) => btnDelete.Visible = false;

            // Add controls
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblDesc);
            panel.Controls.Add(progress);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(lblDate);
            panel.Controls.Add(btnComplete);
            panel.Controls.Add(btnDelete);
            panel.Controls.Add(lblRemaining);

            flowLayoutPanel1.Controls.Add(panel);

            // Hemen temayı uygula
            ThemeHelper.ApplyThemeToControl(panel, ThemeManager.CurrentTheme, skipThemeButtons: true);

            // Panelin yüksekliğini hesapla
            // Bu, öğelerin tüm yüksekliğini içerir (etiketler ve progress bar)
            panel.Height = lblDate.Bottom + 10; // Tarih etiketinin altına 10 px boşluk bırak

        }



        private int CalculateProgress(DateTime targetTime)
        {
            var now = DateTime.Now;
            var totalSpan = targetTime - now;

            var totalMinutes = (targetTime - now).TotalMinutes;
            var maxMinutes = (targetTime - DateTime.Today).TotalMinutes; // Bugün için

            if (totalMinutes <= 0) return 100; // Geçmişse dolu göster
            if (maxMinutes <= 0) return 0;

            return 100 - (int)((totalMinutes / maxMinutes) * 100); // Ne kadar dolduysa
        }

        private void btnOpenAddForm_Click(object sender, EventArgs e)
        {
           
            AddForm addForm = new AddForm();
            addForm.Owner = this;       
            addForm.ShowDialog();

        }

        private string GetTimeRemainingText(DateTime targetTime)
        {
            TimeSpan remaining = targetTime - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
                return "Time's up";

            if (remaining.TotalMinutes < 60)
                return $"{(int)remaining.TotalMinutes} min left";
            else if (remaining.TotalHours < 24)
                return $"{(int)remaining.TotalHours} hr left";
            else
                return $"{(int)remaining.TotalDays} day(s) left";
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private CompletedsForm completedsFormInstance;
        private void completedsbutton_Click(object sender, EventArgs e)
        {
            // Önce JSON verilerini güncelle
            ReminderStorage.UpdateCompletedReminders();

            // Bildirim etiketini güncelle
            UpdateCompletedTasksCount();

            // flowLayoutPanel'den tamamlanmış görevleri kaldır
            foreach (Control control in flowLayoutPanel1.Controls.OfType<Guna.UI2.WinForms.Guna2Panel>().ToList())
            {
                if (control.Tag is Reminder reminder && reminder.IsCompleted)
                {
                    flowLayoutPanel1.Controls.Remove(control);
                    control.Dispose();
                }
            }

            // CompletedsForm'u aç
            if (completedsFormInstance == null || completedsFormInstance.IsDisposed)
            {
                completedsFormInstance = new CompletedsForm();
                completedsFormInstance.Show();
            }
            else
            {
                completedsFormInstance.BringToFront();
            }
        }

        private SettingsForm settingsFormInstance;
        private void settingsbutton_Click(object sender, EventArgs e)
        {
            // SettingsForm'u aç
            if (settingsFormInstance == null || settingsFormInstance.IsDisposed)
            {
                settingsFormInstance = new SettingsForm();
                settingsFormInstance.Show();
            }
            else
            {
                settingsFormInstance.BringToFront();
            }
        }
    }
}
