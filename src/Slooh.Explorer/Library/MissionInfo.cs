using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Slooh.Explorer.Xml;
using Toolbox;

namespace Slooh.Explorer.Library
{
    [DebuggerDisplay("{Date} - {Title,nq}")]
    internal class MissionInfo : INotifyPropertyChanged
    {
        public MissionInfo()
        {
            Title = "Unknown";
            Owner = "Unknown";
            Telescope = "Unknown";
            Instrument = "Unknown";
            Date = DateTime.Today;
            Filename = "";
            Folder = "";
        }

        public MissionInfo(string filename)
        {
            var document = XDocument.Load(filename, LoadOptions.SetLineInfo);
            var element = document.RequiredElement("mission");

            Title = element.RequiredAttribute("title").Value;
            Owner = element.Attribute("owner")?.Value ?? "";
            Telescope = element.RequiredAttribute("telescope").Value;
            Instrument = element.RequiredAttribute("instrument").Value;
            Date = DateTime.Parse(element.RequiredAttribute("date").Value);

            Filename = Path.GetFullPath(filename);
            
            var folderAttribute = element.RequiredAttribute("folder").Value;
            if (Path.IsPathRooted(folderAttribute))
                Folder = folderAttribute;
            else
                Folder = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Filename), folderAttribute));

            var picturesElement = element.Element("pictures");
            if (picturesElement != null)
                Pictures = new BindingList<PictureInfo>(picturesElement.Elements("picture").Select(p => new PictureInfo(this, p)).ToList());
            else
                Pictures = new BindingList<PictureInfo>();

            var fitsElement = element.Element("fits");
            if (fitsElement != null)
                Fits = new BindingList<PictureInfo>(fitsElement.Elements("picture").Select(p => new PictureInfo(this, p)).ToList());
            else
                Fits = new BindingList<PictureInfo>();
        }

        public string Title { get; }
        public string Owner { get; }
        public string Telescope { get; }
        public string Instrument { get; }
        public DateTime Date { get; }

        internal void Delete(PictureInfo picture)
        {
            picture.Delete();

            var document = XDocument.Load(picture.Mission.Filename);

            var pictureElement = document.Root.Element("pictures").Elements("picture").Where(p => p.Attribute("filename").Value == picture.Filename).FirstOrDefault();
            if (pictureElement != null)
                pictureElement.Remove();

            document.Save(picture.Mission.Filename);

            Pictures.Remove(picture);

            OnPropertyChanged(nameof(PicturesCount));
            OnPropertyChanged(nameof(JpegPicturesCount));
        }

        public string Folder { get; }
        public string Filename { get; }

        public BindingList<PictureInfo> Pictures { get; }
        public int PicturesCount => Pictures.Count;
        public int JpegPicturesCount => Pictures.Count(p => p.JpegSaveTo.NotEmpty());
        public BindingList<PictureInfo> Fits { get; }
        public int FitsCount => Fits.Count;

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
