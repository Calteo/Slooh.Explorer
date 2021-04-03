using Slooh.Explorer.Drawing;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace Slooh.Explorer.Filtering
{
    static class Filter
    {
        static Filter()
        {
            Images = new Dictionary<FilterMode, Dictionary<Brush, Image>>();
        }

        private static Dictionary<FilterMode, Dictionary<Brush, Image>> Images { get; }

        public static Image GetImage(FilterMode mode, Brush brush)
        {
            if (!Images.TryGetValue(mode, out var brushes))
                brushes = Images[mode] = new Dictionary<Brush, Image>();
            if (!brushes.TryGetValue(brush, out var image))
            {
                var text = mode.GetType().GetField(mode.ToString()).GetCustomAttribute<TextAttribute>().Text;
                image = brushes[brush] = ImageFactory.CreateFilter(text, brush);
            }
            return image;
        }
    }
}
