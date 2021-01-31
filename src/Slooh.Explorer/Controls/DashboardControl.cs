using Slooh.Explorer.Formats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
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

            comboBoxInformationFormat.DataSource = Formatter;
            comboBoxInformationFormat.DisplayMember = nameof(InformationFormatter.Name);

            Missions.ListChanged += MissionsListChanged;
        }

        private InformationFormatter[] Formatter { get; } = new InformationFormatter[]
            {
                new InformationFormatterXml()
            };

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SortedBindingList<Mission> Missions { get; } = new SortedBindingList<Mission>();

        private CancellationTokenSource TokenSource { get; set; }

        private void MissionsListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    {
                        var mission = Missions[e.NewIndex];
                        Task.Run(() => FetchPictures(mission), TokenSource.Token)
                            .ContinueWith(t => CheckPictures(mission), TokenSource.Token);
                    }
                    break;
            }
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
                textBoxPatternJpeg.Text = "";
                textBoxPatternFits.Text = "";

                checkBoxInformation.Checked
                    = checkBoxOverwriteInformation.Checked
                    = checkBoxPictures.Checked
                    = checkBoxOverwritePictures.Checked
                    = checkBoxJpeg.Checked
                    = checkBoxOverwriteJpeg.Checked
                    = checkBoxFits.Checked
                    = checkBoxOverwriteFits.Checked
                    = false;

                comboBoxInformationFormat.SelectedIndex = 0;
            }
            else
            {
                textBoxFolder.Text = Setting.Folder;

                textBoxPatternMission.Text = Setting.PatternMission;

                checkBoxInformation.Checked = Setting.DownloadInformation;
                textBoxPatternInformation.Text = Setting.PatternInformation;
                var formatter = Formatter.FirstOrDefault(f => f.Name == Setting.InformationFormatter) ?? Formatter[0];
                comboBoxInformationFormat.SelectedItem = formatter;
                
                checkBoxPictures.Checked = Setting.DownloadPictures;
                textBoxPatternPicture.Text = Setting.PatternPicture;
                
                checkBoxJpeg.Checked = Setting.DownloadJpeg;
                textBoxPatternJpeg.Text = Setting.PatternJpeg;
                
                checkBoxFits.Checked = Setting.DownloadFits;
                textBoxPatternFits.Text = Setting.PatternFits;
                                             
                gridMissions.Sort(ColumnTimestamp, ListSortDirection.Descending);

                TokenSource = new CancellationTokenSource();

                Task.Run(GetStatus, TokenSource.Token);
                Task.Run(GetMissions, TokenSource.Token);
                Task.Run(GetPhotosNotInMission, TokenSource.Token);
            }
        }

        private void FetchPictures(Mission mission)
        {
            if (mission.Pictures.Count == mission.ImageCount) return;

            Invoke(new MethodInvoker(() => mission.PicturesState = MissionPictures.Fetching));
            
            var first = 1;
            bool running;
            do
            {
                var picturesResponse = SloohSite.GetPictures(first, mission.Id).Result;
                picturesResponse.Pictures.ForEach(p => p.Mission = mission);
                lock (mission.Pictures)
                {
                    mission.Pictures.AddRange(picturesResponse.Pictures);
                }
                first += picturesResponse.Count;
                running = first < picturesResponse.Total;
            }
            while (running);
        }

        private void FetchFits(Mission mission)
        {
            if ((checkBoxFits.Checked||checkBoxInformation.Checked) && mission.HasFits && mission.FitsPictures.Count == 0)
            {
                mission.State = MissionState.FindFITS;

                var fitsResponse = SloohSite.GetMissionFits(mission.Id).Result;
                foreach (var fitsGroup in fitsResponse.Groups)
                {
                    foreach (var fitsImage in fitsGroup.Images)
                    {
                        var picture = new Picture
                        {
                            SloohSite = SloohSite,
                            Mission = mission,
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
        }

        private void CheckPictures(Mission mission)
        {
            CheckPicturesCore(mission);
        }

        private void CheckPicturesCore(Mission mission)
        {
            var state = MissionPictures.None;
            var missionFolder = GetMissionFolder(mission);

            lock (mission.Pictures)
            {
                var existing = mission.Pictures.Count(p =>
                {
                    var filenname = GetPictureFilename(missionFolder, p, textBoxPatternPicture.Text);
                    return File.Exists(filenname);
                });

                if (existing == mission.ImageCount)
                    state = MissionPictures.Exists;
                else if (existing > 0)
                    state = MissionPictures.Incomplete;
            }

            Invoke(new MethodInvoker(() => mission.PicturesState = state));
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
                        };
                        Missions.Add(mission);
                    }

                    groupDate.ForEach(p => p.Mission = mission);
                    lock (mission.Pictures)
                    {
                        mission.Pictures.AddRange(groupDate);
                    }
                    mission.ImageCount += groupDate.Count();

                    var instruments = mission.Pictures.Select(p => p.Instrument).Distinct().OrderBy(t => t);
                    var telescopes = mission.Pictures.Select(p => p.Telescope).Distinct().OrderBy(t => t);

                    mission.Instrument = string.Join(", ", instruments);
                    mission.Telescope = string.Join(", ", telescopes);
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
            Setting.Folder = textBoxFolder.Text;

            EnableDownload();
            
            Missions.ForEach(m => Task.Run(() => CheckPictures(m)));
        }

        private void TextBoxPatternMissionTextChanged(object sender, EventArgs e)
        {
            Setting.PatternMission = textBoxPatternMission.Text;

            Missions.ForEach(m => Task.Run(() => CheckPictures(m)));
        }

        private void TextBoxPatternPictureTextChanged(object sender, EventArgs e)
        {
            Setting.PatternPicture = textBoxPatternPicture.Text;

            Missions.ForEach(m => Task.Run(() => CheckPictures(m)));
        }

        private void TextBoxPatternFitsTextChanged(object sender, EventArgs e)
        {
            Setting.PatternFits = textBoxPatternFits.Text;
        }

        private void CheckBoxJpegCheckedChanged(object sender, EventArgs e)
        {
            Setting.DownloadJpeg
                = textBoxPatternJpeg.Enabled
                = checkBoxOverwriteJpeg.Enabled
                = checkBoxJpeg.Checked;
        }

        private void TextBoxPatternJpegTextChanged(object sender, EventArgs e)
        {
            Setting.PatternJpeg = textBoxPatternJpeg.Text;
        }

        private static Regex PatternReplacments { get; } = new Regex(@"\$\{(?<name>\w+)(:(?<format>[^}]+))?\}", RegexOptions.Compiled);

        private CancellationTokenSource DownloadTokenSource { get; set; }

        private async void ButtonDownloadClick(object sender, EventArgs e)
        {
            tableLayoutPanelHeader.Enabled = false;

            Setting.Save();

            DownloadTokenSource = new CancellationTokenSource();

            var formatter = (InformationFormatter)comboBoxInformationFormat.SelectedItem;

            var missions = gridMissions.SelectedRows.Cast<DataGridViewRow>().Select(r => (Mission)r.DataBoundItem);
            missions.ForEach(m => m.State = MissionState.Scheduled);
            var tasks = missions.Select(m => new Task(() => Download(m, formatter), DownloadTokenSource.Token)).ToArray();

            progressBarDownload.Value = 0;
            progressBarDownload.Maximum = tasks.Length;
            progressBarDownload.Visible = true;

            tasks.ForEach(t => t.Start());

            await Task.WhenAll(tasks);

            progressBarDownload.Visible = false;
            tableLayoutPanelHeader.Enabled = true;
        }

        private void Download(Mission mission, InformationFormatter formatter)
        {
            FetchPictures(mission);
            FetchFits(mission);

            var missionFolder = GetMissionFolder(mission);
            
            if (!Directory.Exists(missionFolder))
                Directory.CreateDirectory(missionFolder);

            if (checkBoxInformation.Checked)
            {
                var filename = PatternReplacments.Replace(textBoxPatternInformation.Text, m => ReplacePatterns(m, mission));
                if (!Path.IsPathRooted(filename))
                    filename = Path.Combine(missionFolder, filename);

                filename = Path.ChangeExtension(filename, formatter.Extension);

                if (checkBoxOverwriteInformation.Checked || !File.Exists(filename))                
                    formatter.Save(filename, mission);
            }

            mission.State = MissionState.Downloading;
            foreach (var picture in mission.Pictures)
            {
                Download(missionFolder, picture, textBoxPatternPicture.Text, checkBoxOverwritePictures.Checked);
                if (checkBoxJpeg.Checked)
                    Download(missionFolder, picture, textBoxPatternJpeg.Text, checkBoxOverwriteJpeg.Checked, "jpeg", SavePictureJpeg);

                picture.ResetStream();
            }

            if (checkBoxFits.Checked)
            {
                foreach (var picture in mission.FitsPictures)
                {
                    Download(missionFolder, picture, textBoxPatternFits.Text, checkBoxOverwriteFits.Checked);
                    picture.ResetStream();
                }
            }

            mission.State = MissionState.Finished;

            CheckPictures(mission);

            Invoke(new MethodInvoker(DownloadTick));
        }

        private void DownloadTick()
        {
            progressBarDownload.Value++;            
        }

        private string GetMissionFolder(Mission mission)
        {
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

            return buffer.ToString();
        }

        private string GetPictureFilename(string missionFolder, Picture picture, string pattern)
        {
            var filename = PatternReplacments.Replace(pattern, m => ReplacePatterns(m, picture));
            if (!Path.IsPathRooted(filename))
                filename = Path.Combine(missionFolder, filename);

            return filename;
        }

        private void Download(string missionFolder, Picture picture, string pattern, bool overwrite, string extension = null, Action<Picture, string> saveAction = null)
        {
            var filename = GetPictureFilename(missionFolder, picture, pattern);

            if (extension.NotEmpty())
                filename = Path.ChangeExtension(filename, extension);

            var folder = Path.GetDirectoryName(filename);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            if (!overwrite && File.Exists(filename)) return;

            if (saveAction != null)
                saveAction(picture, filename);
            else
                picture.SaveStream(filename);
        }

        private void SavePictureJpeg(Picture picture, string filename)
        {
            var decoder = new PngBitmapDecoder(picture.GetStream(), BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

            var encoder = new JpegBitmapEncoder();
            encoder.QualityLevel = 100;

            var metadata = new BitmapMetadata("jpg")
            {
                Author = new System.Collections.ObjectModel.ReadOnlyCollection<string>(new List<string> { picture.Owner }),
                DateTaken = picture.Timestamp.ToString(CultureInfo.InvariantCulture),
                Title = picture.Title,
                Subject = $"Mission: {picture.Mission.Timestamp} - {picture.Mission.Title}",
                ApplicationName = "www.slooh.com",
                CameraManufacturer = picture.Telescope,
                CameraModel = picture.Instrument,
                Copyright = "slooh.com",
            };
            
            encoder.Frames.Add(BitmapFrame.Create(decoder.Frames[0], null, metadata, decoder.Frames[0].ColorContexts));

            using (var fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                encoder.Save(fileStream);
            }
            File.SetCreationTimeUtc(filename, picture.Timestamp);
        }

        private string Normalize(string text)
        {
            var builder = new StringBuilder(text);

            builder.Replace(':', '#');

            Path.GetInvalidPathChars().ForEach(c => builder.Replace(c, '_'));
            Path.GetInvalidFileNameChars().ForEach(c => builder.Replace(c, '_'));

            return builder.ToString();
        }

        private string ReplacePatterns(Match match, Mission mission)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "title":
                    {
                        return Normalize(mission.Title);
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
                case "filename":
                    {
                        return picture.Filename;
                    }
                case "title":
                    {
                        return Normalize(picture.Title);
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

        private void DownloadEnded()
        {
            textBoxFolder.Enabled = textBoxPatternMission.Enabled = buttonSelectFolder.Enabled = buttonDownload.Enabled = true;
        }

        private void CheckBoxFitsCheckedChanged(object sender, EventArgs e)
        {
            Setting.DownloadFits
                = textBoxPatternFits.Enabled 
                = checkBoxOverwriteFits.Enabled
                = checkBoxFits.Checked;
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

        public IEnumerable<Mission> SelectedMissions => gridMissions.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem).Cast<Mission>();

        private void ToolStripMenuItemOpenFolderClick(object sender, EventArgs e)
        {            
                SelectedMissions.ForEach(mission =>
                {
                    var folder = GetMissionFolder(mission);
                    if (Directory.Exists(folder))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = folder,
                            UseShellExecute = true,
                            Verb = "open"
                        });
                    }
                });
        }

        private void ContextMenuStripMissionsOpening(object sender, CancelEventArgs e)
        {
            toolStripMenuItemOpenFolder.Enabled = SelectedMissions.Any();
        }

        private void ComboBoxInformationFormatSelectedIndexChanged(object sender, EventArgs e)
        {
            if (Setting == null) return;

            if (comboBoxInformationFormat.SelectedIndex >= 0)
            {
                Setting.InformationFormatter = Formatter[comboBoxInformationFormat.SelectedIndex].Name;
            }
            else
            {
                Setting.InformationFormatter = null;
            }
        }

        private void CheckBoxInformationCheckedChanged(object sender, EventArgs e)
        {
            Setting.DownloadInformation
                = textBoxPatternInformation.Enabled
                = checkBoxOverwriteInformation.Enabled
                = comboBoxInformationFormat.Enabled
                = checkBoxInformation.Checked;
        }

        private void TextBoxPatternInformationTextChanged(object sender, EventArgs e)
        {
            Setting.PatternInformation = textBoxPatternInformation.Text;
        }

        private void CheckBoxPicturesCheckedChanged(object sender, EventArgs e)
        {
            Setting.DownloadPictures
                = textBoxPatternPicture.Enabled
                = checkBoxOverwritePictures.Enabled
                = checkBoxPictures.Checked;
        }
    }
}
