using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reminder
{
    public class Theme
    {
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public Color GradientButtonColor { get; set; }
        public Color PanelTextColor { get; set; }
        public Color PanelBackColor { get; set; }

        public string SettingsIconPath { get; set; }
        public string CheckmarkIconPath { get; set; }
    }
}
