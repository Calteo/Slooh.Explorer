using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using Slooh.Explorer.Drawing;
using Toolbox;

namespace Slooh.Explorer
{
    internal class SloohCacheStorageMissionThumbnails : SloohCacheStorage<Image, Mission>
    {
        public SloohCacheStorageMissionThumbnails(SloohCache cache) : base(cache, "MissionThumbnails")
        {
            UnknownThumbnail = new Bitmap(200, 200);

            using Graphics g = Graphics.FromImage(UnknownThumbnail);

            var rect = new Rectangle(0, 0, 199, 199);
            g.DrawRectangle(Pens.White, rect);
            var icon = SystemIcons.Question;
            g.DrawIcon(icon, (rect.Width - icon.Width) / 2, (rect.Height - icon.Height) / 2);
        }

        private Image UnknownThumbnail { get; }

        private void FetchThumbnail(Mission mission)
        {
            var picture = Site.GetPicture(mission.ImageUrl).Result;
            if (picture != null)
            {
                var thumbnail = ImageFactory.GetThumbnail(picture, 200);
                Set(mission, thumbnail);
                mission.ThumbnailArrived = true;
            }
        }

        protected override string GetFilename(Mission mission)
        {
            return $"ID-{mission.Id}";
        }

        protected override void Write(Stream stream, Image image)
        {
            image.Save(stream, ImageFormat.Jpeg);
        }

        protected override Image Read(Stream stream)
        {
            return Image.FromStream(stream);
        }

        protected override Image CacheMiss(Mission mission)
        {
            if (mission.ImageUrl.NotEmpty())
                Task.Run(() => FetchThumbnail(mission));

            return UnknownThumbnail;
        }
    }
}
