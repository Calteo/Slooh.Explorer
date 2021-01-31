using System.ComponentModel;
using System.Drawing;
using Toolbox.Xml.Serialization;
using Toolbox.Xml.Settings;

namespace Slooh.Explorer
{
    class SloohUserSetting : UserSetting
    {
        [DefaultValue("")]
        public string Name { get; set; }

        [DefaultValue(""), Obfuscate]
        public string Password { get; set; }

        [DefaultValue(false)]
        public bool SavePassword { get; set; }

        [DefaultValue("")]
        public string Folder { get; set; }

        [DefaultValue(@"${title}\${date:yyyy-MM-dd}\${date:HH-mm-ss}")]
        public string PatternMission { get; set; }

        [DefaultValue(@"${instrument}\${filename}")]
        public string PatternPicture { get; set; }

        [DefaultValue(false)]
        public bool DownloadJpeg { get; set; }
        [DefaultValue(@"Jpeg\${instrument}\${filename}")]
        public string PatternJpeg { get; set; }

        [DefaultValue(true)]
        public bool DownloadFits { get; set; }
        [DefaultValue(@"FITS\${instrument}\${filename}")]
        public string PatternFits { get; set; }

        [DefaultValue(null)]
        public string Formatter { get; set; }
                
        public Point Location { get; set; }
        public Size Size { get; set; }       
    }
}
