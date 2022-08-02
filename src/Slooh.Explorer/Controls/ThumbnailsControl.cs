using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Slooh.Explorer.Drawing;
using Toolbox;

namespace Slooh.Explorer.Controls
{
    internal partial class ThumbnailsControl : SloohControl
    {
        public ThumbnailsControl()
        {
            InitializeComponent();

            missionsListChangedHandler = MissionsListChanged;

            Missions.ListChanged += MissionsListChanged;
        }

        private void MissionsListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    MissionsReset();
                    break;
                case ListChangedType.ItemAdded:
                    MissionsAdded(Missions[e.NewIndex]);
                    break;
                case ListChangedType.ItemChanged:
                    MissionsListChanged(Missions[e.NewIndex], e.PropertyDescriptor);
                    break;
            }
        }

        delegate void MissionsListChangedHandler(Mission mission, PropertyDescriptor property);
        MissionsListChangedHandler missionsListChangedHandler;

        private void MissionsListChanged(Mission mission, PropertyDescriptor property)
        {
            if (InvokeRequired)
            {
                Invoke(missionsListChangedHandler, mission, property);
                return;
            }

            if (property.Name == nameof(Mission.ThumbnailArrived))
            {
                var pictureBox = flowLayoutPanel.Controls.OfType<PictureBox>().FirstOrDefault(pb => pb.Tag == mission);
                if (pictureBox != null)
                {
                    pictureBox.Image = SloohSite.GetMissionThumbnail(mission);
                    pictureBox.Size = pictureBox.Image.Size;
                }
            }
        }

        private void MissionsAdded(Mission mission)
        {
            var pictures = mission.Pictures.Where(p => p.Thumbnail != null);
            if (pictures.Any())
            {
                foreach (var p in pictures)
                {
                    var control = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Image = p.Thumbnail,
                        Width = p.Thumbnail.Width,
                        Height = p.Thumbnail.Height,
                        Tag = p
                    };
                    toolTip.SetToolTip(control, $"{p.DisplayDate} {p.DisplayTime}\r\n{p.Title}\r\n{p.Telescope}\r\n{p.Instrument}\r\n{p.Filename}");
                    control.DoubleClick += PictureDoubleClicked;
                    control.Click += PictureClick;

                    flowLayoutPanel.Controls.Add(control);
                }
            }
            else
            {
                if (mission.ImageUrl.NotEmpty())
                {
                    var image = SloohSite.GetMissionThumbnail(mission);
                    // var image = SystemIcons.Question.ToBitmap();
                    // var image = Image.FromStream(SloohSite.GetPicture(mission.ImageUrl));
                    var control = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Image = image,
                        Width = image.Width,
                        Height = image.Height,
                        Tag = mission
                    };
                    toolTip.SetToolTip(control, $"{mission.DisplayDate} {mission.DisplayTime}\r\n{mission.Title}\r\n{mission.Telescope}\r\n{mission.Instrument}\r\nThumbnail");
                    flowLayoutPanel.Controls.Add(control);
                }
            }
        }

        private void MissionsReset()
        {
            toolTip.RemoveAll();
            flowLayoutPanel.Controls.Clear();
        }

        private BindingList<Mission> Missions { get; } = new BindingList<Mission>();

        public void ShowThumbnails(IEnumerable<Mission> missions)
        {
            Missions.Clear();

            foreach (Mission mission in missions)
                Missions.Add(mission);

            /*
            toolTip.RemoveAll();            
            flowLayoutPanel.Controls.Clear();

            if (missions == null) return;

            foreach (var mission in missions)
            {
                var pictures = mission.Pictures.Where(p => p.Thumbnail != null);
                if (pictures.Count() > 0)
                {
                    foreach (var p in pictures)
                    {
                        var control = new PictureBox
                        {
                            SizeMode = PictureBoxSizeMode.CenterImage,
                            Image = p.Thumbnail,
                            Width = p.Thumbnail.Width,
                            Height = p.Thumbnail.Height,
                            Tag = p
                        };
                        toolTip.SetToolTip(control, $"{p.DisplayDate} {p.DisplayTime}\r\n{p.Title}\r\n{p.Telescope}\r\n{p.Instrument}\r\n{p.Filename}");
                        control.DoubleClick += PictureDoubleClicked;
                        control.Click += PictureClick;

                        flowLayoutPanel.Controls.Add(control);  
                    }
                }
                else 
                {
                    if (mission.ImageUrl.NotEmpty())
                    {
                        var image = ImageFactory.GetThumbnail(await SloohSite.GetPicture(mission.ImageUrl));
                        // var image = SystemIcons.Question.ToBitmap();
                        // var image = Image.FromStream(SloohSite.GetPicture(mission.ImageUrl));
                        var control = new PictureBox
                        {
                            SizeMode = PictureBoxSizeMode.CenterImage,
                            Image = image,
                            Width = image.Width,
                            Height = image.Height,
                        };
                        toolTip.SetToolTip(control, $"{mission.DisplayDate} {mission.DisplayTime}\r\n{mission.Title}\r\n{mission.Telescope}\r\n{mission.Instrument}\r\nThumbnail");
                        flowLayoutPanel.Controls.Add(control);
                    }                    
                }
            }
            */
        }

        private void PictureClick(object sender, EventArgs e)
        {
            var control = (PictureBox)sender;

            if (!ModifierKeys.HasFlag(Keys.Control)) return;

            if (control.BorderStyle == BorderStyle.None)
            {
                control.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                control.BorderStyle = BorderStyle.None;
            }
        }

        private void PictureDoubleClicked(object sender, EventArgs e)
        {
            var control = (Control)sender;
            var p = (Picture)control.Tag;

            Process.Start("explorer", p.ThumbnailFilename);
        }

        private void ContextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            toolStripMenuItemDelete.Enabled = flowLayoutPanel.Controls.OfType<PictureBox>().Any(c => c.BorderStyle == BorderStyle.Fixed3D);
        }
    }
}