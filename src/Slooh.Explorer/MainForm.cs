using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        private void MainFromShown(object sender, EventArgs e)
        {
            logonControl.Setting = dashboardControl.Setting =
                Setting = UserSettings.Get<SloohUserSetting>();

            /*
            var site = new SloohSite();
            await site.GetSessionToken();
            await site.Logon();
            await site.GetGravityStatus();
            */
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
    }
}
