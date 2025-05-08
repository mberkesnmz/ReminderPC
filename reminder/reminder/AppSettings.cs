using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reminder
{
    public class AppSettings
    {
        public string SelectedThemeName { get; set; } = "green_light";

        private string _notificationSoundPath = "notification.wav";
        public string NotificationSoundPath
        {
            get => string.IsNullOrWhiteSpace(_notificationSoundPath) ? "notification.wav" : _notificationSoundPath;
            set => _notificationSoundPath = value;
        }
    }
}
