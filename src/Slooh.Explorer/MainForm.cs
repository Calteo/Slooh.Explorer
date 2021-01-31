using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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

    }
}
