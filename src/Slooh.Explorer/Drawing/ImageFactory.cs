using System.Drawing;
using System.Drawing.Imaging;

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
    }
}