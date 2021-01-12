using System.ComponentModel;
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

        [DefaultValue(@"${title}\${date:yy-MM-dd}\${date:HH-mm-ss}")]
        public string PatternMission { get; set; }
        [DefaultValue("${instrument}")]
        public string PatternPicture { get; set; }
        [DefaultValue(@"FITS\${instrument}")]
        public string PatternFits { get; set; }
    }
}
