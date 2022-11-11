namespace Slooh.Explorer.Controls
{
    partial class LibraryControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.gridViewMissions = new Slooh.Explorer.Controls.SloohDataGridView();
            this.ColumnDate = new Slooh.Explorer.Filtering.DataGridViewFilterDateTimeColumn();
            this.ColumnTitle = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnTelescope = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnInstrument = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnOwner = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnPictures = new Slooh.Explorer.Filtering.DataGridViewFilterIntegerColumn();
            this.ColumnJpeg = new Slooh.Explorer.Filtering.DataGridViewFilterIntegerColumn();
            this.ColumnFits = new Slooh.Explorer.Filtering.DataGridViewFilterIntegerColumn();
            this.thumbnailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMissions)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(430, 925);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewAfterSelect);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainer.Size = new System.Drawing.Size(1352, 925);
            this.splitContainer.SplitterDistance = 430;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 1;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.gridViewMissions);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.thumbnailsPanel);
            this.splitContainerRight.Size = new System.Drawing.Size(916, 925);
            this.splitContainerRight.SplitterDistance = 326;
            this.splitContainerRight.TabIndex = 0;
            // 
            // gridViewMissions
            // 
            this.gridViewMissions.AllowUserToAddRows = false;
            this.gridViewMissions.AllowUserToDeleteRows = false;
            this.gridViewMissions.AllowUserToResizeRows = false;
            this.gridViewMissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewMissions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridViewMissions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.gridViewMissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewMissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewMissions.ColumnHeadersHeight = 60;
            this.gridViewMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewMissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnTitle,
            this.ColumnTelescope,
            this.ColumnInstrument,
            this.ColumnOwner,
            this.ColumnPictures,
            this.ColumnJpeg,
            this.ColumnFits});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMissions.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewMissions.EnableHeadersVisualStyles = false;
            this.gridViewMissions.Location = new System.Drawing.Point(0, 0);
            this.gridViewMissions.Name = "gridViewMissions";
            this.gridViewMissions.ReadOnly = true;
            this.gridViewMissions.RowHeadersVisible = false;
            this.gridViewMissions.RowHeadersWidth = 51;
            this.gridViewMissions.RowTemplate.Height = 29;
            this.gridViewMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewMissions.Size = new System.Drawing.Size(916, 326);
            this.gridViewMissions.TabIndex = 0;
            this.gridViewMissions.SelectionChanged += new System.EventHandler(this.GridViewMissionsSelectionChanged);
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "Date";
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 81;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.MinimumWidth = 50;
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnTitle.Width = 200;
            // 
            // ColumnTelescope
            // 
            this.ColumnTelescope.DataPropertyName = "Telescope";
            this.ColumnTelescope.HeaderText = "Telescope";
            this.ColumnTelescope.MinimumWidth = 6;
            this.ColumnTelescope.Name = "ColumnTelescope";
            this.ColumnTelescope.ReadOnly = true;
            this.ColumnTelescope.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTelescope.Width = 124;
            // 
            // ColumnInstrument
            // 
            this.ColumnInstrument.DataPropertyName = "Instrument";
            this.ColumnInstrument.HeaderText = "Instrument";
            this.ColumnInstrument.MinimumWidth = 6;
            this.ColumnInstrument.Name = "ColumnInstrument";
            this.ColumnInstrument.ReadOnly = true;
            this.ColumnInstrument.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInstrument.Width = 134;
            // 
            // ColumnOwner
            // 
            this.ColumnOwner.DataPropertyName = "Owner";
            this.ColumnOwner.HeaderText = "Owner";
            this.ColumnOwner.MinimumWidth = 6;
            this.ColumnOwner.Name = "ColumnOwner";
            this.ColumnOwner.ReadOnly = true;
            this.ColumnOwner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOwner.Width = 97;
            // 
            // ColumnPictures
            // 
            this.ColumnPictures.DataPropertyName = "PicturesCount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnPictures.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPictures.HeaderText = "Pictures";
            this.ColumnPictures.MinimumWidth = 6;
            this.ColumnPictures.Name = "ColumnPictures";
            this.ColumnPictures.ReadOnly = true;
            this.ColumnPictures.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPictures.Width = 108;
            // 
            // ColumnJpeg
            // 
            this.ColumnJpeg.DataPropertyName = "JpegPicturesCount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnJpeg.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnJpeg.HeaderText = "JPEG";
            this.ColumnJpeg.MinimumWidth = 6;
            this.ColumnJpeg.Name = "ColumnJpeg";
            this.ColumnJpeg.ReadOnly = true;
            this.ColumnJpeg.Width = 82;
            // 
            // ColumnFits
            // 
            this.ColumnFits.DataPropertyName = "FitsCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnFits.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnFits.HeaderText = "FITS";
            this.ColumnFits.MinimumWidth = 6;
            this.ColumnFits.Name = "ColumnFits";
            this.ColumnFits.ReadOnly = true;
            this.ColumnFits.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFits.Width = 76;
            // 
            // thumbnailsPanel
            // 
            this.thumbnailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailsPanel.Location = new System.Drawing.Point(0, 0);
            this.thumbnailsPanel.Name = "thumbnailsPanel";
            this.thumbnailsPanel.Size = new System.Drawing.Size(916, 595);
            this.thumbnailsPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRefresh});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1352, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuItemRefresh
            // 
            this.menuItemRefresh.Name = "menuItemRefresh";
            this.menuItemRefresh.Size = new System.Drawing.Size(72, 24);
            this.menuItemRefresh.Text = "Refresh";
            this.menuItemRefresh.Click += new System.EventHandler(this.MenuItemRefreshClick);
            // 
            // LibraryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "LibraryControl";
            this.Size = new System.Drawing.Size(1352, 953);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMissions)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefresh;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private SloohDataGridView gridViewMissions;
        private System.Windows.Forms.FlowLayoutPanel thumbnailsPanel;
        private Filtering.DataGridViewFilterDateTimeColumn ColumnDate;
        private Filtering.DataGridViewFilterTextColumn ColumnTitle;
        private Filtering.DataGridViewFilterTextColumn ColumnTelescope;
        private Filtering.DataGridViewFilterTextColumn ColumnInstrument;
        private Filtering.DataGridViewFilterTextColumn ColumnOwner;
        private Filtering.DataGridViewFilterIntegerColumn ColumnPictures;
        private Filtering.DataGridViewFilterIntegerColumn ColumnJpeg;
        private Filtering.DataGridViewFilterIntegerColumn ColumnFits;
    }
}
