using System.Windows.Forms;
using System.Drawing;

namespace Slooh.Explorer.Controls
{
    class SloohButton : Button
    {
        public SloohButton()
        {
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.WhiteSmoke;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 52, 70);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 160, 104);
        }
    }
}
