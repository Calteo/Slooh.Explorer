namespace Slooh.Explorer.Controls
{
    partial class LibraryThumbnailControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCaption = new System.Windows.Forms.Label();
            this.panelThumnails = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePictureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.pictureContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCaption
            // 
            this.labelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCaption.Location = new System.Drawing.Point(0, 0);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(552, 39);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Caption";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelThumnails
            // 
            this.panelThumnails.BackColor = System.Drawing.Color.Transparent;
            this.panelThumnails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThumnails.Location = new System.Drawing.Point(0, 39);
            this.panelThumnails.Name = "panelThumnails";
            this.panelThumnails.Size = new System.Drawing.Size(552, 174);
            this.panelThumnails.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 28);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItemClick);
            // 
            // pictureContextMenuStrip
            // 
            this.pictureContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pictureContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePictureMenuItem});
            this.pictureContextMenuStrip.Name = "contextMenuStrip1";
            this.pictureContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            // 
            // deletePictureMenuItem
            // 
            this.deletePictureMenuItem.Name = "deletePictureMenuItem";
            this.deletePictureMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deletePictureMenuItem.Text = "Delete";
            this.deletePictureMenuItem.Click += new System.EventHandler(this.DeletePictureMenuItemClick);
            // 
            // LibraryThumbnailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.panelThumnails);
            this.Controls.Add(this.labelCaption);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LibraryThumbnailControl";
            this.Size = new System.Drawing.Size(552, 213);
            this.contextMenuStrip.ResumeLayout(false);
            this.pictureContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Panel panelThumnails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ContextMenuStrip pictureContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deletePictureMenuItem;
    }
}
