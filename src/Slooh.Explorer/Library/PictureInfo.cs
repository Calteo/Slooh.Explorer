using System;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using Slooh.Explorer.Drawing;
using Slooh.Explorer.Xml;
using Toolbox;

namespace Slooh.Explorer.Library
{
    internal class PictureInfo
    {
        public PictureInfo(MissionInfo mission, XElement element)
        {
            Mission = mission;

            Filename = element.RequiredAttribute("filename").Value;

            SaveTo = element.Attribute("saveTo")?.Value;
            if (SaveTo.NotEmpty() && !Path.IsPathRooted(SaveTo))
                SaveTo = Path.GetFullPath(Path.Combine(Mission.Folder, SaveTo));

            JpegSaveTo = element.Attribute("jpegSaveTo")?.Value;
            if (JpegSaveTo.NotEmpty() && !Path.IsPathRooted(JpegSaveTo))
                JpegSaveTo = Path.GetFullPath(Path.Combine(Mission.Folder, JpegSaveTo));
        }

        public MissionInfo Mission { get; }

        public string Filename { get; }
        public string SaveTo { get; }
        public string JpegSaveTo { get; }

        public Bitmap Thumbnail { get; set; }
        
        internal Bitmap GetThumbnail(int size)
        {
            if (size != Thumbnail?.Width)
            {
                if (SaveTo.NotEmpty())
                {
                    try
                    {
                        using var stream = new FileStream(SaveTo, FileMode.Open, FileAccess.Read, FileShare.Read);
                        Thumbnail = ImageFactory.GetThumbnail(stream, size);
                    }
                    catch (Exception)
                    {
                        Thumbnail = new Bitmap(SystemIcons.Error.ToBitmap(), size, size);
                    }
                }
            }

            return Thumbnail;
        }

        internal void Delete()
        {
            if (SaveTo.NotEmpty())
                File.Delete(SaveTo);
            if (JpegSaveTo.NotEmpty())
                File.Delete(JpegSaveTo);
        }
    }
}
