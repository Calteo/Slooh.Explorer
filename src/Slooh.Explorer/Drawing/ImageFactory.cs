using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Slooh.Explorer.Drawing
{    
    static class ImageFactory
    {
        public static Image CreateFilter(string text, Brush brush)
        {
            var image = new Bitmap(18, 18, PixelFormat.Format32bppArgb);
            using (var g = Graphics.FromImage(image))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                var font = new Font(FontFamily.GenericSansSerif, 12);
                var rect = g.MeasureString(text, font);
                g.DrawString(text, font, brush, (image.Width - rect.Width) / 2, (image.Height - rect.Height) / 2);
            }

            return image;
        }

        internal static Bitmap GetThumbnail(string filename, int size)
        {
            var directoryThumbnail = Path.Combine(Path.GetDirectoryName(filename), @"thumbs");
            var filenameThumbnail = Path.Combine(directoryThumbnail, Path.GetFileName(filename));
            if (File.Exists(filenameThumbnail))
                return (Bitmap)Image.FromFile(filenameThumbnail);

            using var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);

            var bitmap = GetThumbnail(stream, size);

            if (!Directory.Exists(directoryThumbnail))
                Directory.CreateDirectory(directoryThumbnail);

            bitmap.Save(filenameThumbnail);

            return bitmap;
        }

        internal static Bitmap GetThumbnail(Stream stream, int size)
        {
            using var image = Image.FromStream(stream);

            var wPercentage = (float)size / image.Width;
            var hPercentage = (float)size / image.Height;
            var percentage = Math.Min(wPercentage, hPercentage);

            var thumbnail = new Bitmap((int)(image.Width * percentage), (int)(image.Height * percentage));

            using var g = Graphics.FromImage(thumbnail);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, thumbnail.Width, thumbnail.Height);
            return thumbnail;
        }
    }
}