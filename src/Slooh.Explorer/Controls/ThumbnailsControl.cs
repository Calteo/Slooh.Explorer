using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Slooh.Explorer.Controls
{
    internal partial class ThumbnailsControl : SloohControl
    {
        public ThumbnailsControl()
        {
            InitializeComponent();
        }
       
        public void ShowThumbnails(IEnumerable<Mission> missions)
        {
            toolTip.RemoveAll();
            flowLayoutPanel.Controls.Clear();

            var controls = missions?.SelectMany(m => m.Pictures)
                .Where(p => p.Thumbnail != null)
                .Select(p => new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Image = p.Thumbnail,
                    Width = p.Thumbnail.Width,
                    Height = p.Thumbnail.Height,                    
                    Tag = p
                }).ToArray();

            foreach (var control in controls)
            {
                var p = (Picture)control.Tag;
                toolTip.SetToolTip(control, $"{p.DisplayDate} {p.DisplayTime}\r\n{p.Title}\r\n{p.Telescope}\r\n{p.Instrument}");
                control.DoubleClick += PictureDoubleClicked;
            }
        
            flowLayoutPanel.Controls.AddRange(controls);                            
        }

        private void PictureDoubleClicked(object sender, EventArgs e)
        {
            var control = (Control)sender;
            var p = (Picture)control.Tag;

            Process.Start("explorer", p.ThumbnailFilename);
        }
    }
}
