using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reminder
{
    public class AppSettings
    {
        public string SelectedThemeName { get; set; } = "green_light"; // default
        public string NotificationSoundPath { get; set; } = "notification.wav"; // gelecek adım için
    }
}
