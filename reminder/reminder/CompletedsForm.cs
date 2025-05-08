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

namespace reminder
{

    public partial class CompletedsForm : Form
    {

        public CompletedsForm()
        {

            InitializeComponent();
            flowLayoutPanel1.SizeChanged += (s, e) => UpdatePanelWidths();
            
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
            var reminders = ReminderStorage.Load();
            foreach (var reminder in reminders.Where(r => r.IsCompleted))
            {
                AddReminderToPanel(reminder);
            }

            ReminderStorage.UpdateCompletedReminders();

            var settings = SettingsStorage.Load();
            string themeName = settings.SelectedThemeName ?? "green_light"; // varsayılan tema

            // Tema adını kullanarak uygula
            ThemeManager.ApplyTheme(themeName);

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
            int progressY = 10 + btnDelete.Height + 5; // Butonlardan sonra 5px boşluk

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
                ShadowDecoration = { Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle },
                ShowPercentage = false,
                Value = CalculateProgress(reminder.DateTime),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                UseTransparentBackground = true,
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



            btnDelete.Click += (s, e) =>
            {
                flowLayoutPanel1.Controls.Remove(panel);
                ReminderStorage.Delete(reminder); // JSON'dan sil
            };

            // Hover eventleri
            panel.MouseEnter += (s, e) =>
            {
                btnDelete.Visible = true;
            };

            panel.MouseLeave += (s, e) =>
            {
                // Fare panel dışına çıkarsa gizle
                if (!btnDelete.Bounds.Contains(panel.PointToClient(Cursor.Position)))
                {
                    btnDelete.Visible = false;
                }
            };

            // Butonlara özel MouseEnter/Leave (gizlenmesin diye)
           
            btnDelete.MouseEnter += (s, e) => btnDelete.Visible = true;
          
            btnDelete.MouseLeave += (s, e) => btnDelete.Visible = false;

            // Add controls
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblDesc);
            panel.Controls.Add(progress);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(lblDate);
           
            panel.Controls.Add(btnDelete);
            panel.Controls.Add(lblRemaining);

            flowLayoutPanel1.Controls.Add(panel);

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

    }
}
