using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Controls
{
    class SloohProgressBar : Control
    {
        public SloohProgressBar()
        {
            Maximum = MaximumDefault;
        }

        private int _value;
        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                Invalidate();
            }
        }

        private const int MaximumDefault = 100;
        
        private int _maximum;

        [DefaultValue(MaximumDefault)]
        public int Maximum
        { 
            get => _maximum;
            set
            {
                _maximum = value;
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(62, 74, 84)), ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = ClientRectangle;
            rect.Width = (rect.Width * Value) / Maximum;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(192, 158, 101)), rect);
        }
    }
}
