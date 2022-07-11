using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Toolbox.Help;
using Toolbox.Help.WinForms;
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
            var setting = UserSettings.Get<SloohUserSetting>(name);
            if (setting.Folder == null)
                setting.Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Slooh");

            logonControl.Setting
                = dashboardControl.Setting
                = Setting
                = setting;

            if (Setting.Location != Point.Empty)
                Location = Setting.Location;
            if (Setting.Size != Size.Empty)
                Size = Setting.Size;

            SingletonHelpForm.Server = new HelpServer(GetType(), "Help");
            SingletonHelpForm.OwnerForm = this;
        }

        private void MainFromShown(object sender, EventArgs e)
        {
        }

        private void LogonControlLoggedOn(object sender, EventArgs e)
        {
            logonControl.Visible = false;
            dashboardControl.Visible = true;
            dashboardControl.SloohSite = logonControl.SloohSite;
            menuItemClearCache.Enabled = true;
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
            menuItemClearCache.Enabled = false;
            
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

        private void MenuItemHelpMainClick(object sender, EventArgs e)
        {
            SingletonHelpForm.Navigate("index.html");
        }

        private void MenuItemClearCacheClick(object sender, EventArgs e)
        {
            dashboardControl.SloohSite.ClearCache();
            MessageBox.Show(this, "Cache cleared.", "Slooh Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
