using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Toolbox;
using Toolbox.Update;
using Toolbox.Xml.Settings;

namespace Slooh.Explorer
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SloohOptions Options { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public SloohUserSetting Setting { get; set; }

        private void MainFormLoad(object sender, EventArgs e)
        {
#if DEBUG
            var name = "DEBUG";
#else
            string name = null;
#endif
            logonControl.Setting
                = dashboardControl.Setting
                = Setting
                = UserSettings.Get<SloohUserSetting>(name);

            if (Setting.Location != Point.Empty)
                Location = Setting.Location;
            if (Setting.Size != Size.Empty)
                Size = Setting.Size;
        }

        private void MainFromShown(object sender, EventArgs e)
        {
        }

        private void LogonControlLoggedOn(object sender, EventArgs e)
        {
            logonControl.Visible = false;
            dashboardControl.Visible = true;
            dashboardControl.SloohSite = logonControl.SloohSite;
            menuItemLogoff.Enabled = true;
        }

        private void MenuItemQuitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemLogoffClick(object sender, EventArgs e)
        {
            dashboardControl.SloohSite = null;

            logonControl.Visible = true;
            dashboardControl.Visible = false;
            
            menuItemLogoff.Enabled = false;
        }

        private void MainFormResize(object sender, EventArgs e)
        {
            if (Setting != null && WindowState == FormWindowState.Normal)
            {
                Setting.Size = Size;
            }
        }

        private void MainFormLocationChanged(object sender, EventArgs e)
        {
            if (Setting!=null && WindowState==FormWindowState.Normal)
            {
                Setting.Location = Location;
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Setting.Save();
        }

        private void MenuItemVersionClick(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            MessageBox.Show(this, $"Version - {version.Major}.{version.Minor}.{version.Build}", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemCheckUpdateClick(object sender, EventArgs e)
        {
            var updater = new GitHubUpdater("Calteo", "Slooh.Explorer");
            var latest = updater.GetLatestVersion();
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var latestVersion = new Version(latest.Version.Trim('v'));

            if (version == latestVersion)
            {
                MessageBox.Show(this, "Latest version already installed.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Newer version {latest.Version} available.");
                if (latest.Name != latest.Version)
                    builder.AppendLine($"Named {latest.Name}");
                builder.AppendLine($"Published {latest.Published}");
                if (latest.Description.NotEmpty())
                    builder.AppendLine(latest.Description);
                builder.AppendLine();
                builder.Append("Install this version?");

                var result = MessageBox.Show(this, builder.ToString(), Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updater.Install(latest);
                    Close();
                }
            }            
        }
    }
}
