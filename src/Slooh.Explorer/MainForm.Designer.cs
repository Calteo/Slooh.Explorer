﻿using System.Drawing;

namespace Slooh.Explorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.logonControl = new Slooh.Explorer.Controls.LogonControl();
            this.dashboardControl = new Slooh.Explorer.Controls.DashboardControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // logonControl
            // 
            this.logonControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.logonControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logonControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logonControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logonControl.Location = new System.Drawing.Point(0, 24);
            this.logonControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logonControl.Name = "logonControl";
            this.logonControl.Size = new System.Drawing.Size(962, 482);
            this.logonControl.TabIndex = 0;
            this.logonControl.LoggedOn += new System.EventHandler(this.LogonControlLoggedOn);
            // 
            // dashboardControl
            // 
            this.dashboardControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.dashboardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboardControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardControl.Location = new System.Drawing.Point(0, 24);
            this.dashboardControl.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardControl.Name = "dashboardControl";
            this.dashboardControl.Size = new System.Drawing.Size(962, 482);
            this.dashboardControl.TabIndex = 1;
            this.dashboardControl.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMain});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(962, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemMain
            // 
            this.menuItemMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLogoff,
            this.toolStripSeparator1,
            this.menuItemQuit});
            this.menuItemMain.Name = "menuItemMain";
            this.menuItemMain.Size = new System.Drawing.Size(46, 20);
            this.menuItemMain.Text = "Main";
            // 
            // menuItemLogoff
            // 
            this.menuItemLogoff.Enabled = false;
            this.menuItemLogoff.Name = "menuItemLogoff";
            this.menuItemLogoff.Size = new System.Drawing.Size(139, 22);
            this.menuItemLogoff.Text = "Logoff";
            this.menuItemLogoff.Click += new System.EventHandler(this.MenuItemLogoffClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.ShortcutKeyDisplayString = "";
            this.menuItemQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemQuit.Size = new System.Drawing.Size(139, 22);
            this.menuItemQuit.Text = "Quit";
            this.menuItemQuit.ToolTipText = "Ends this application";
            this.menuItemQuit.Click += new System.EventHandler(this.MenuItemQuitClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(962, 506);
            this.Controls.Add(this.logonControl);
            this.Controls.Add(this.dashboardControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Slooh Explorer";
            this.Shown += new System.EventHandler(this.MainFromShown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private Controls.LogonControl logonControl;
        private Controls.DashboardControl dashboardControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogoff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
    }
}
