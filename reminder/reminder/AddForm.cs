using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reminder
{
    public partial class AddForm : Form
    {

        public AddForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Value = DateTime.Now;

            datePicker.Value = DateTime.Now;

            var settings = SettingsStorage.Load();
            string themeName = settings.SelectedThemeName ?? "green_light"; // varsayılan tema

            // Tema adını kullanarak uygula
            ThemeManager.ApplyTheme(themeName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DateTime = datePicker.Value.Date + timePicker.Value.TimeOfDay,
                IsCompleted = false
            };

            // JSON'a kaydet
            var existingReminders = ReminderStorage.Load();
            existingReminders.Add(reminder);
            ReminderStorage.Save(existingReminders);

            // Ana forma aktar
            if (this.Owner is AddReminderForm mainForm)
            {
                mainForm.AddReminderToPanel(reminder);
            }

            this.Close(); // AddForm'u kapat
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
