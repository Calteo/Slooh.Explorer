using System.Drawing;
using System.IO;
using System.Xml.Linq;
using Slooh.Explorer.Drawing;
using Toolbox;

namespace Slooh.Explorer.Library
{
    internal class PictureInfo
    {
        public PictureInfo(MissionInfo mission, XElement element)
        {
            Mission = mission;
            SaveTo = element.Attribute("saveTo")?.Value;
            if (SaveTo.NotEmpty() && !Path.IsPathRooted(SaveTo))
                SaveTo = Path.GetFullPath(Path.Combine(Mission.Folder, SaveTo));
            JpegSaveTo = element.Attribute("jpegSaveTo")?.Value;
            if (JpegSaveTo.NotEmpty() && !Path.IsPathRooted(JpegSaveTo))
                JpegSaveTo = Path.GetFullPath(Path.Combine(Mission.Folder, JpegSaveTo));
        }

        public MissionInfo Mission { get; }

        public string SaveTo { get; }
        public string JpegSaveTo { get; }

        public Bitmap Thumbnail { get; set; }

        internal Bitmap GetThumbnail(int size)
        {
            if (size != Thumbnail?.Width)
            {
                if (SaveTo.NotEmpty())
                {
                    using var stream = new FileStream(SaveTo, FileMode.Open, FileAccess.Read, FileShare.Read);
                    Thumbnail = ImageFactory.GetThumbnail(stream, size);
                }
            }

            return Thumbnail;
        }
    }
}
