using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox;
using Toolbox.Collection.Generics;
using Toolbox.ComponentModel;

namespace Slooh.Explorer.Controls
{
    internal partial class DashboardControl : SloohControl
    {
        public DashboardControl()
        {
            InitializeComponent();

            gridMissions.AutoGenerateColumns = false;            
            gridMissions.DataSource = Missions;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SortedBindingList<Mission> Missions { get; } = new SortedBindingList<Mission>();

        private CancellationTokenSource TokenSource { get; set; }

        protected override void OnSloohSiteChanged()
        {
            base.OnSloohSiteChanged();

            TokenSource?.Cancel();
            Missions.Clear();

            if (SloohSite == null)
            {
                labelName.Text =
                labelMemberSince.Text =
                labelTier.Text =
                labelGravityPoints.Text = "";

                sloohProgressBar.Value = 0;
                labelNextTierPoints.Text = 
                labelNextTier.Text = "";

                textBoxFolder.Text = "";
                textBoxPatternMission.Text = "";
                textBoxPatternPicture.Text = "";
                textBoxPatternFits.Text = "";
            }
            else
            {
                textBoxFolder.Text = Setting.Folder;
                textBoxPatternMission.Text = Setting.PatternMission;
                textBoxPatternPicture.Text = Setting.PatternPicture;
                textBoxPatternFits.Text = Setting.PatternFits;

                gridMissions.Sort(ColumnTimestamp, ListSortDirection.Descending);

                TokenSource = new CancellationTokenSource();

                Task.Run(GetStatus, TokenSource.Token);
                Task.Run(GetMissions, TokenSource.Token);
                Task.Run(GetPhotosNotInMission, TokenSource.Token);
            }
        }

        private async void GetStatus()
        {
            await SloohSite.GetGravityStatus();

            if (TokenSource.Token.IsCancellationRequested) return;

            BeginInvoke(new MethodInvoker(SetStatus));
        }

        private void SetStatus()
        {
            labelName.Text = SloohSite.DisplayName;
            labelMemberSince.Text = SloohSite.MemberSince;
            labelTier.Text = SloohSite.Tier;
            labelGravityPoints.Text = $"{SloohSite.Points} GP";

            labelNextTierPoints.Text = $"{SloohSite.ProgressPoints}/{SloohSite.NeededPoints}";
            labelNextTier.Text = SloohSite.NextTier;

            sloohProgressBar.Value = 0;
            sloohProgressBar.Maximum = SloohSite.NeededPoints;
            sloohProgressBar.Value = SloohSite.ProgressPoints;            
        }

        private void GetMissions()
        {
            var first = 1;
            var running = true;
            do
            {
                var response = SloohSite.GetMissions(first).Result;
                Invoke(new AddMissionsDelegate(AddMissions), new object[] { response.Missions });
                first += response.Count;
                running = first < response.Total;
            }
            while (running && !TokenSource.Token.IsCancellationRequested);
        }

        private delegate void AddMissionsDelegate(Mission[] missions);
        private void AddMissions(Mission[] missions)
        {
            foreach (var mission in missions)
            {
                Missions.Add(mission);
            }
            gridMissions.AutoResizeColumns();
        }

        private void GetPhotosNotInMission()
        {
            var first = 1;
            var running = true;
            do
            {
                var response = SloohSite.GetPictures(first).Result;
                Invoke(new AddPicturesDelegate(AddPictures), new object[] { response.Pictures });
                first += response.Count;
                running = first < response.Total;
            }
            while (running && !TokenSource.Token.IsCancellationRequested);
        }

        private delegate void AddPicturesDelegate(Picture[] pictures);
        private void AddPictures(Picture[] pictures)
        {
            foreach (var groupTitle in pictures.GroupBy(p => p.Title))
            {
                foreach (var groupDate in groupTitle.GroupBy(p => p.Timestamp.Date))
                {
                    var mission = Missions.FirstOrDefault(m => m.Title == groupTitle.Key && m.Timestamp.Date == groupDate.Key);
                    if (mission == null)
                    {
                        mission = new Mission
                        {
                            Id = 0,
                            HasFits = false,
                            Title = groupTitle.Key,
                            Timestamp = groupDate.Select(p => p.Timestamp).Min(),
                            Owner = groupDate.First().Owner,
                            Instrument = "",
                            Telescope = ""
                        };
                        Missions.Add(mission);
                    }
                    mission.Pictures.AddRange(groupDate);
                    mission.ImageCount += groupDate.Count();
                }
            }
        }

        private void EnableDownload()
        {
            buttonDownload.Enabled = textBoxFolder.Text.NotEmpty() && gridMissions.SelectedRows.Count > 0;
        }

        private void ButtonSelectFolderClick(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = textBoxFolder.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                textBoxFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void GridMissionsSelectionChanged(object sender, EventArgs e)
        {
            EnableDownload();
        }

        private void TextBoxFolderTextChanged(object sender, EventArgs e)
        {
            EnableDownload();
        }

        private static Regex PatternReplacments { get; } = new Regex(@"\$\{(?<name>\w+)(:(?<format>[^}]+))?\}", RegexOptions.Compiled);

        private CancellationTokenSource DownloadTokenSource { get; set; }

        private async void ButtonDownloadClick(object sender, EventArgs e)
        {
            textBoxFolder.Enabled = buttonSelectFolder.Enabled =
                textBoxPatternMission.Enabled = textBoxPatternPicture.Enabled = textBoxPatternFits.Enabled =
                buttonDownload.Enabled = false;

            Setting.Folder = textBoxFolder.Text;
            Setting.PatternMission = textBoxPatternMission.Text;
            Setting.PatternPicture = textBoxPatternPicture.Text;
            Setting.PatternFits = textBoxPatternFits.Text;
            Setting.Save();

            DownloadTokenSource = new CancellationTokenSource();

            var missions = gridMissions.SelectedRows.Cast<DataGridViewRow>().Select(r => (Mission)r.DataBoundItem);
            missions.ForEach(m => m.State = MissionState.Scheduled);
            var tasks = missions.Select(m => new Task(() => Download(m), DownloadTokenSource.Token)).ToArray();

            progressBarDownload.Value = 0;
            progressBarDownload.Maximum = tasks.Length;
            progressBarDownload.Visible = true;

            tasks.ForEach(t => t.Start());

            await Task.WhenAll(tasks);

            progressBarDownload.Visible = false;

            textBoxFolder.Enabled = buttonSelectFolder.Enabled =
                textBoxPatternMission.Enabled = textBoxPatternMission.Enabled = textBoxPatternPicture.Enabled = 
                buttonDownload.Enabled = true;

            textBoxPatternFits.Enabled = checkBoxFits.Checked;
        }

        private void Download(Mission mission)
        {
            if (mission.Pictures.Count == 0)
            {
                mission.State = MissionState.FindPictures;

                var first = 1;
                bool running;
                do
                {
                    var picturesResponse = SloohSite.GetPictures(first, mission.Id).Result;
                    mission.Pictures.AddRange(picturesResponse.Pictures);
                    first += picturesResponse.Count;
                    running = first < picturesResponse.Total;
                }
                while (running);
            }
            if (checkBoxFits.Checked && mission.HasFits && mission.FitsPictures.Count==0)
            {
                mission.State = MissionState.FindFITS;

                var fitsResponse = SloohSite.GetMissionFits(mission.Id).Result;
                foreach (var fitsGroup in fitsResponse.Groups)
                {
                    foreach (var fitsImage in fitsGroup.Images)
                    {
                        var picture = new Picture
                        {
                            Title = mission.Title,
                            Data = new Picture.OverlayData { Owner = mission.Owner },
                            Timestamp = mission.Timestamp,
                            Telescope = mission.Telescope,
                            Instrument = fitsGroup.Name,
                            DownloadUrl = fitsImage.DownloadUrl,
                            Filename = fitsImage.Title
                        };
                        mission.FitsPictures.Add(picture);
                    }
                }
            }

            var missionPattern = PatternReplacments.Replace(textBoxPatternMission.Text, m => ReplacePatterns(m, mission));
            var missionFolder = Path.Combine(Setting.Folder, missionPattern);

            var invalid = Path.GetInvalidPathChars().ToHashSet();
            var buffer = new StringBuilder(missionFolder);
            var start = Path.IsPathRooted(missionFolder) ? Path.GetPathRoot(missionFolder).Length : 0;

            for (var i = start; i < buffer.Length; i++)
            {
                if (invalid.Contains(buffer[i]))
                    buffer[i] = '_';
                else if (buffer[i] == ':')
                    buffer[i] = '.';
            }

            missionFolder = buffer.ToString();
            
            if (!Directory.Exists(missionFolder))
                Directory.CreateDirectory(missionFolder);

            mission.State = MissionState.Downloading;
            foreach (var picture in mission.Pictures)
            {
                Download(missionFolder, picture, textBoxPatternPicture.Text);
            }
            if (checkBoxFits.Checked)
            {
                foreach (var picture in mission.FitsPictures)
                {
                    Download(missionFolder, picture, textBoxPatternFits.Text);
                }
            }

            Invoke(new MethodInvoker(DownloadTick));
            mission.State = MissionState.Finished;
        }

        private void DownloadTick()
        {
            progressBarDownload.Value++;            
        }

        private void Download(string missionFolder, Picture picture, string pattern)
        {
            var stream = SloohSite.GetPicture(picture.DownloadUrl).Result;

            var picturePattern = PatternReplacments.Replace(pattern, m => ReplacePatterns(m, picture));
            var pictureFolder = Path.Combine(missionFolder, picturePattern);

            if (!Directory.Exists(pictureFolder))
                Directory.CreateDirectory(pictureFolder);

            using (var fileStream = new FileStream(Path.Combine(pictureFolder, picture.Filename), FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }

        private string ReplacePatterns(Match match, Mission mission)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "title":
                    {
                        return mission.Title;
                    }
                case "date":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return mission.Timestamp.ToString(format);
                    }
                case "instrument":
                    {
                        return mission.Instrument;
                    }
                case "telescope":
                    {
                        return mission.Telescope;
                    }
                default:
                    {
                        return $"Unknown-{name}";
                    }
            }
        }

        private string ReplacePatterns(Match match, Picture picture)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "title":
                    {
                        return picture.Title;
                    }
                case "date":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return picture.Timestamp.ToString(format);
                    }
                case "telescope":
                    {
                        return picture.Telescope;
                    }
                case "instrument":
                    {
                        return picture.Instrument;
                    }
                default:
                    {
                        return $"Unknown-{name}";
                    }
            }
        }


        private void DownloadEnded(Task task)
        {
            Invoke(new MethodInvoker(DownloadEnded));
        }

        private void DownloadEnded()
        {
            textBoxFolder.Enabled = textBoxPatternMission.Enabled = buttonSelectFolder.Enabled = buttonDownload.Enabled = true;
        }

        private void CheckBoxFitsCheckedChanged(object sender, EventArgs e)
        {
            textBoxPatternFits.Enabled = checkBoxFits.Checked;
        }

        private void GridMissionsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == ColumnState.Index)
            {
                var state = (MissionState)e.Value;
                if (state == MissionState.None)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
