using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Slooh.Explorer.Xml;
using Toolbox;

namespace Slooh.Explorer.Library
{
    [DebuggerDisplay("{Date} - {Title,nq}")]
    internal class MissionInfo
    {
        public MissionInfo()
        {
            Title = "Unknown";
            Owner = "Unknown";
            Telescope = "Unknown";
            Instrument = "Unknown";
            Date = DateTime.Today;
            Folder = "";
        }

        public MissionInfo(string folder, XElement element)
        {
            Title = element.RequiredAttribute("title").Value;
            Owner = element.Attribute("owner")?.Value ?? "";
            Telescope = element.RequiredAttribute("telescope").Value;
            Instrument = element.RequiredAttribute("instrument").Value;
            Date = DateTime.Parse(element.RequiredAttribute("date").Value);

            var folderAttribute = element.RequiredAttribute("folder").Value;
            if (Path.IsPathRooted(folderAttribute))
                Folder = folderAttribute;
            else
                Folder = Path.GetFullPath(Path.Combine(folder, folderAttribute));

            var picturesElement = element.Element("pictures");
            if (picturesElement != null)
                Pictures = picturesElement.Elements("picture").Select(p => new PictureInfo(this, p)).ToArray();
            else
                Pictures = Array.Empty<PictureInfo>();

            var fitsElement = element.Element("fits");
            if (fitsElement != null)
                Fits = fitsElement.Elements("picture").Select(p => new PictureInfo(this, p)).ToArray();
            else
                Fits = Array.Empty<PictureInfo>();
        }

        public string Title { get; }
        public string Owner { get; }
        public string Telescope { get; }
        public string Instrument { get; }
        public DateTime Date { get; }
        public string Folder { get; }

        public PictureInfo[] Pictures { get; }
        public int PicturesCount => Pictures.Length;
        public int JpegPicturesCount => Pictures.Count(p => p.JpegSaveTo.NotEmpty());
        public PictureInfo[] Fits { get; }
        public int FitsCount => Fits.Length;

        internal static MissionInfo Load(string file)
        {
            var document = XDocument.Load(file, LoadOptions.SetLineInfo);
            
            var missionInfo = new MissionInfo(Path.GetDirectoryName(file), document.RequiredElement("mission"));

            return missionInfo;
        }
    }
}
