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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                var font = new Font(FontFamily.GenericSansSerif, 12);
                var rect = g.MeasureString(text, font);
                g.DrawString(text, font, brush, (image.Width - rect.Width) / 2, (image.Height - rect.Height) / 2);
            }

            return image;
        }

        internal static Bitmap GetThumbnail(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return GetThumbnail(stream);
            }
        }

        internal static Bitmap GetThumbnail(Stream stream)
        {
            try
            {
                using (var image = Image.FromStream(stream))
                {
                    var wPercentage = 200f / image.Width;
                    var hPercentage = 200f / image.Height;
                    var percentage = Math.Min(wPercentage, hPercentage);

                    var thumbnail = new Bitmap((int)(image.Width * percentage), (int)(image.Height * percentage));
                    using (var g = Graphics.FromImage(thumbnail))
                    {
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(image, 0, 0, thumbnail.Width, thumbnail.Height);
                        return thumbnail;
                    }
                }
            }
            catch 
            {
                return SystemIcons.Error.ToBitmap();
            }
        }
    }
}