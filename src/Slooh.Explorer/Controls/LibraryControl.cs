using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slooh.Explorer.Filtering;
using Slooh.Explorer.Library;
using Toolbox.Collection.Generics;
using Toolbox.ComponentModel;

namespace Slooh.Explorer.Controls
{
    internal partial class LibraryControl : SloohControl
    {
        public LibraryControl()
        {
            InitializeComponent();

            Missions.ListChanged += MissionsListChanged;

            treeView.TreeViewNodeSorter = new LibraryTreeNodeComparer();

            gridViewMissions.AutoGenerateColumns = false;
            gridViewMissions.DataSource = FilteredMissions;
            
            Filters = gridViewMissions.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderCell).OfType<DataGridViewFilterHeaderCell>().ToArray();
            Filters.ForEach(hc => hc.FilterChanged += MissionFilterChanged);

            RootNode = new LibraryTreeNode("Library");
            treeView.Nodes.Add(RootNode);
            RootNode.Expand();            
        }

        public DataGridViewFilterHeaderCell[] Filters { get; }

        private void MissionFilterChanged(object sender, EventArgs e)
        {
            lock (Missions)
            {
                Missions.ForEach(ApplyFilter);
            }
        }

        private void ApplyFilter(MissionInfo mission)
        {
            var accept = false;

            if (Filters.All(f => f.Accept(mission)))
            {
                if (treeView.SelectedNode is LibraryTreeNode node)
                {
                    accept = node.Missions.Contains(mission);
                }
            }

            if (accept)
            {
                if (!FilteredMissions.Contains(mission))
                    FilteredMissions.Add(mission);
            }
            else
            {
                FilteredMissions.Remove(mission);
            }
        }

        public LibraryTreeNode RootNode { get; }

        private SortedBindingList<MissionInfo> Missions { get; } = new SortedBindingList<MissionInfo>();
        private SortedBindingList<MissionInfo> FilteredMissions { get; } = new SortedBindingList<MissionInfo>();

        private void MissionsListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    Insert(Missions[e.NewIndex]);
                    if (!RootNode.IsExpanded) RootNode.Expand();                    
                    break;
                case ListChangedType.Reset:
                    RootNode.Nodes.Clear();
                    break;
            }
        }

        private static Regex PatternReplacments { get; } = new Regex(@"\$\{(?<name>\w+)(:(?<format>[^}]+))?\}", RegexOptions.Compiled);
        private string Pattern { get; set; } = @"${title}\${instrument}\${date:yyyy-MM}";

        private void Insert(MissionInfo missionInfo)
        {
            var path = PatternReplacments.Replace(Pattern, m => ReplacePatterns(m, missionInfo));

            var queue = new Queue<string>(path.Split('\\'));

            Insert(missionInfo, queue, RootNode);
        }

        private void Insert(MissionInfo missionInfo, Queue<string> queue, LibraryTreeNode parent)
        {
            parent.Missions.Add(missionInfo);

            var name = queue.Dequeue();
            var node = parent.Nodes.Find(name, false).Cast<LibraryTreeNode>().FirstOrDefault();
            if (node == null)
            {
                node = new LibraryTreeNode(name) { Name = name };
                parent.Nodes.Add(node);
            }
            if (queue.Count == 0)
            {
                node.Missions.Add(missionInfo);
            }
            else
            {
                Insert(missionInfo, queue, node);
            }
        }

        private static string ReplacePatterns(Match match, MissionInfo missionInfo)
        {
            var name = match.Groups["name"].Value;

            switch (name.ToLower())
            {
                case "title":
                    {
                        return missionInfo.Title;
                    }
                case "owner":
                    {
                        return missionInfo.Owner;
                    }
                case "date":
                    {
                        var format = match.Groups["format"].Value ?? "yyyy-MM-dd-HH-mm-ss";
                        return missionInfo.Date.ToString(format);
                    }
                case "telescope":
                    {
                        return missionInfo.Telescope;
                    }
                case "instrument":
                    {
                        return missionInfo.Instrument;
                    }
                default:
                    {
                        return $"Unknown-{name}";
                    }
            }

        }

        public string Folder { get; set; }

        public CancellationTokenSource TokenSource { get; set; }

        public void Scan()
        {
            TokenSource?.Cancel();
            TokenSource = new CancellationTokenSource();

            Missions.Clear();
            menuItemRefresh.Enabled = false;

            Task.Run(() => ScanFolder(), TokenSource.Token)
                .ContinueWith(t => Invoke(() => menuItemRefresh.Enabled = true));
        }

        private void ScanFolder()
        {
            foreach (var file in Directory.EnumerateFiles(Folder, "*.xml", SearchOption.AllDirectories))
            {
                try
                {
                    var missionInfo = new MissionInfo(file);
                    Invoke(() =>
                        {
                            Missions.Add(missionInfo);
                            ApplyFilter(missionInfo);
                        });
                }
                catch (Exception exception)
                {
                    Trace.WriteLine(exception.Message, file);
                }
            }
        }

        private void MenuItemRefreshClick(object sender, EventArgs e)
        {
            Scan();
        }

        private void TreeViewAfterSelect(object sender, TreeViewEventArgs e)
        {
            Missions.ForEach(ApplyFilter);
        }

        private void GridViewMissionsSelectionChanged(object sender, EventArgs e)
        {
            var missions = gridViewMissions.SelectedRows.Cast<DataGridViewRow>().OrderBy(r => r.Index).Select(row => (MissionInfo)row.DataBoundItem).ToArray();

            thumbnailsPanel.Controls.Clear();

            foreach (var mission in missions)
            {
                var thumbnail = new LibraryThumbnailControl { Mission = mission };

                thumbnailsPanel.Controls.Add(thumbnail);
            }                       
        }

    }
}
