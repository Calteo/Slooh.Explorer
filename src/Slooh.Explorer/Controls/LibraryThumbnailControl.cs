using System.Windows.Forms;
using Slooh.Explorer.Library;

namespace Slooh.Explorer.Controls;

internal partial class LibraryThumbnailControl : SloohControl
{
    public LibraryThumbnailControl()
    {
        InitializeComponent();
    }

    private const int PictureSize = 200;

    private MissionInfo _mission;
    public MissionInfo Mission
    {
        get => _mission;
        set
        {
            panelThumnails.Controls.Clear();

            _mission = value;

            labelCaption.Text = _mission?.Title ?? "Mission";

            var left = 5;

            foreach (var picture in _mission.Pictures)
            {
                var thumbnail = picture.GetThumbnail(PictureSize);

                if (thumbnail != null)
                {
                    var pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.CenterImage,
                        Image = thumbnail,
                        Width = PictureSize,
                        Height = PictureSize,
                        Top = 5,
                        Left = left
                    };
                    panelThumnails.Controls.Add(pictureBox);
                    left += pictureBox.Width + 5;
                }
            }

            Width = left + 5;
            Height = 10 + labelCaption.Height + PictureSize;
        }
    }
}
