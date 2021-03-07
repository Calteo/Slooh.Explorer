
namespace Slooh.Explorer.Controls
{
    partial class DashboardControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridMissions = new Slooh.Explorer.Controls.SloohDataGridView();
            this.ColumnTimestamp = new Slooh.Explorer.Filtering.DataGridViewFilterDateTimeColumn();
            this.ColumnTitle = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnPicturesState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFits = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTelescope = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnInstrument = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnOwner = new Slooh.Explorer.Filtering.DataGridViewFilterTextColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripMissions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxOverwriteJpeg = new System.Windows.Forms.CheckBox();
            this.textBoxPatternFits = new System.Windows.Forms.TextBox();
            this.textBoxPatternPicture = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new Slooh.Explorer.Controls.SloohButton();
            this.labelPatternMission = new System.Windows.Forms.Label();
            this.textBoxPatternMission = new System.Windows.Forms.TextBox();
            this.buttonDownload = new Slooh.Explorer.Controls.SloohButton();
            this.progressBarDownload = new Slooh.Explorer.Controls.SloohProgressBar();
            this.checkBoxFits = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwritePictures = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwriteFits = new System.Windows.Forms.CheckBox();
            this.comboBoxInformationFormat = new System.Windows.Forms.ComboBox();
            this.checkBoxJpeg = new System.Windows.Forms.CheckBox();
            this.textBoxPatternJpeg = new System.Windows.Forms.TextBox();
            this.textBoxPatternInformation = new System.Windows.Forms.TextBox();
            this.checkBoxOverwriteInformation = new System.Windows.Forms.CheckBox();
            this.checkBoxInformation = new System.Windows.Forms.CheckBox();
            this.checkBoxPictures = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMemberSince = new System.Windows.Forms.Label();
            this.labelTier = new System.Windows.Forms.Label();
            this.labelGravityPoints = new System.Windows.Forms.Label();
            this.labelNextTierPoints = new System.Windows.Forms.Label();
            this.labelNextTier = new System.Windows.Forms.Label();
            this.sloohProgressBar = new Slooh.Explorer.Controls.SloohProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMissions)).BeginInit();
            this.contextMenuStripMissions.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridMissions);
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanelHeader);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelRight);
            this.splitContainer.Size = new System.Drawing.Size(1188, 695);
            this.splitContainer.SplitterDistance = 906;
            this.splitContainer.TabIndex = 0;
            // 
            // gridMissions
            // 
            this.gridMissions.AllowUserToAddRows = false;
            this.gridMissions.AllowUserToDeleteRows = false;
            this.gridMissions.AllowUserToResizeRows = false;
            this.gridMissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridMissions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridMissions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.gridMissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMissions.ColumnHeadersHeight = 60;
            this.gridMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTimestamp,
            this.ColumnTitle,
            this.ColumnPicturesState,
            this.ColumnImageCount,
            this.ColumnFits,
            this.ColumnTelescope,
            this.ColumnInstrument,
            this.ColumnOwner,
            this.ColumnState});
            this.gridMissions.ContextMenuStrip = this.contextMenuStripMissions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMissions.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMissions.EnableHeadersVisualStyles = false;
            this.gridMissions.Location = new System.Drawing.Point(0, 298);
            this.gridMissions.Name = "gridMissions";
            this.gridMissions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMissions.RowHeadersVisible = false;
            this.gridMissions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(145)))), ((int)(((byte)(87)))));
            this.gridMissions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridMissions.RowTemplate.Height = 25;
            this.gridMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMissions.ShowEditingIcon = false;
            this.gridMissions.Size = new System.Drawing.Size(906, 397);
            this.gridMissions.TabIndex = 0;
            this.gridMissions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridMissionsCellFormatting);
            this.gridMissions.SelectionChanged += new System.EventHandler(this.GridMissionsSelectionChanged);
            // 
            // ColumnTimestamp
            // 
            this.ColumnTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTimestamp.DataPropertyName = "Timestamp";
            this.ColumnTimestamp.Frozen = true;
            this.ColumnTimestamp.HeaderText = "Date";
            this.ColumnTimestamp.Name = "ColumnTimestamp";
            this.ColumnTimestamp.ReadOnly = true;
            this.ColumnTimestamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTimestamp.Width = 150;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.Frozen = true;
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTitle.Width = 250;
            // 
            // ColumnPicturesState
            // 
            this.ColumnPicturesState.DataPropertyName = "PicturesState";
            this.ColumnPicturesState.Frozen = true;
            this.ColumnPicturesState.HeaderText = "P";
            this.ColumnPicturesState.Name = "ColumnPicturesState";
            this.ColumnPicturesState.ReadOnly = true;
            this.ColumnPicturesState.Width = 43;
            // 
            // ColumnImageCount
            // 
            this.ColumnImageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnImageCount.DataPropertyName = "ImageCount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnImageCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnImageCount.Frozen = true;
            this.ColumnImageCount.HeaderText = "Images";
            this.ColumnImageCount.Name = "ColumnImageCount";
            this.ColumnImageCount.ReadOnly = true;
            this.ColumnImageCount.Width = 84;
            // 
            // ColumnFits
            // 
            this.ColumnFits.DataPropertyName = "HasFits";
            this.ColumnFits.HeaderText = "FITS";
            this.ColumnFits.Name = "ColumnFits";
            this.ColumnFits.ReadOnly = true;
            this.ColumnFits.Width = 44;
            // 
            // ColumnTelescope
            // 
            this.ColumnTelescope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTelescope.DataPropertyName = "Telescope";
            this.ColumnTelescope.HeaderText = "Telescope";
            this.ColumnTelescope.Name = "ColumnTelescope";
            this.ColumnTelescope.ReadOnly = true;
            this.ColumnTelescope.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnInstrument
            // 
            this.ColumnInstrument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnInstrument.DataPropertyName = "Instrument";
            this.ColumnInstrument.HeaderText = "Instrument";
            this.ColumnInstrument.Name = "ColumnInstrument";
            this.ColumnInstrument.ReadOnly = true;
            this.ColumnInstrument.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInstrument.Width = 110;
            // 
            // ColumnOwner
            // 
            this.ColumnOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOwner.DataPropertyName = "Owner";
            this.ColumnOwner.HeaderText = "Owner";
            this.ColumnOwner.Name = "ColumnOwner";
            this.ColumnOwner.ReadOnly = true;
            this.ColumnOwner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOwner.Width = 150;
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnState.DataPropertyName = "State";
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            // 
            // contextMenuStripMissions
            // 
            this.contextMenuStripMissions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFolder});
            this.contextMenuStripMissions.Name = "contextMenuStripMissions";
            this.contextMenuStripMissions.Size = new System.Drawing.Size(149, 26);
            this.contextMenuStripMissions.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripMissionsOpening);
            // 
            // toolStripMenuItemOpenFolder
            // 
            this.toolStripMenuItemOpenFolder.Name = "toolStripMenuItemOpenFolder";
            this.toolStripMenuItemOpenFolder.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemOpenFolder.Text = "Open Folder...";
            this.toolStripMenuItemOpenFolder.Click += new System.EventHandler(this.ToolStripMenuItemOpenFolderClick);
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelHeader.ColumnCount = 4;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxOverwriteJpeg, 2, 4);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxPatternFits, 1, 5);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxPatternPicture, 1, 3);
            this.tableLayoutPanelHeader.Controls.Add(this.labelFolder, 0, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxFolder, 1, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.buttonSelectFolder, 2, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.labelPatternMission, 0, 1);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxPatternMission, 1, 1);
            this.tableLayoutPanelHeader.Controls.Add(this.buttonDownload, 3, 6);
            this.tableLayoutPanelHeader.Controls.Add(this.progressBarDownload, 0, 7);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxFits, 0, 5);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxOverwritePictures, 2, 3);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxOverwriteFits, 2, 5);
            this.tableLayoutPanelHeader.Controls.Add(this.comboBoxInformationFormat, 3, 2);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxJpeg, 0, 4);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxPatternJpeg, 1, 4);
            this.tableLayoutPanelHeader.Controls.Add(this.textBoxPatternInformation, 1, 2);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxOverwriteInformation, 2, 2);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxInformation, 0, 2);
            this.tableLayoutPanelHeader.Controls.Add(this.checkBoxPictures, 0, 3);
            this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 9;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(906, 298);
            this.tableLayoutPanelHeader.TabIndex = 1;
            // 
            // checkBoxOverwriteJpeg
            // 
            this.checkBoxOverwriteJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOverwriteJpeg.Enabled = false;
            this.checkBoxOverwriteJpeg.Location = new System.Drawing.Point(659, 139);
            this.checkBoxOverwriteJpeg.Name = "checkBoxOverwriteJpeg";
            this.checkBoxOverwriteJpeg.Size = new System.Drawing.Size(119, 28);
            this.checkBoxOverwriteJpeg.TabIndex = 20;
            this.checkBoxOverwriteJpeg.Text = "Overwrite";
            this.checkBoxOverwriteJpeg.UseVisualStyleBackColor = true;
            // 
            // textBoxPatternFits
            // 
            this.textBoxPatternFits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternFits.Enabled = false;
            this.textBoxPatternFits.Location = new System.Drawing.Point(123, 173);
            this.textBoxPatternFits.Name = "textBoxPatternFits";
            this.textBoxPatternFits.Size = new System.Drawing.Size(530, 29);
            this.textBoxPatternFits.TabIndex = 10;
            this.textBoxPatternFits.TextChanged += new System.EventHandler(this.TextBoxPatternFitsTextChanged);
            // 
            // textBoxPatternPicture
            // 
            this.textBoxPatternPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternPicture.Location = new System.Drawing.Point(123, 105);
            this.textBoxPatternPicture.Name = "textBoxPatternPicture";
            this.textBoxPatternPicture.Size = new System.Drawing.Size(530, 29);
            this.textBoxPatternPicture.TabIndex = 8;
            this.textBoxPatternPicture.TextChanged += new System.EventHandler(this.TextBoxPatternPictureTextChanged);
            // 
            // labelFolder
            // 
            this.labelFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFolder.Location = new System.Drawing.Point(3, 0);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(114, 34);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folder";
            this.labelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFolder.Location = new System.Drawing.Point(123, 3);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(530, 29);
            this.textBoxFolder.TabIndex = 1;
            this.textBoxFolder.TextChanged += new System.EventHandler(this.TextBoxFolderTextChanged);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.buttonSelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.buttonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFolder.Location = new System.Drawing.Point(659, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(119, 28);
            this.buttonSelectFolder.TabIndex = 2;
            this.buttonSelectFolder.Text = "Select";
            this.buttonSelectFolder.UseVisualStyleBackColor = false;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolderClick);
            // 
            // labelPatternMission
            // 
            this.labelPatternMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPatternMission.Location = new System.Drawing.Point(3, 34);
            this.labelPatternMission.Name = "labelPatternMission";
            this.labelPatternMission.Size = new System.Drawing.Size(114, 34);
            this.labelPatternMission.TabIndex = 3;
            this.labelPatternMission.Text = "Mission";
            this.labelPatternMission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPatternMission
            // 
            this.textBoxPatternMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternMission.Location = new System.Drawing.Point(123, 37);
            this.textBoxPatternMission.Name = "textBoxPatternMission";
            this.textBoxPatternMission.Size = new System.Drawing.Size(530, 29);
            this.textBoxPatternMission.TabIndex = 4;
            this.textBoxPatternMission.TextChanged += new System.EventHandler(this.TextBoxPatternMissionTextChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Transparent;
            this.buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDownload.Enabled = false;
            this.buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Location = new System.Drawing.Point(784, 207);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(119, 28);
            this.buttonDownload.TabIndex = 5;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownloadClick);
            // 
            // progressBarDownload
            // 
            this.tableLayoutPanelHeader.SetColumnSpan(this.progressBarDownload, 4);
            this.progressBarDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarDownload.Location = new System.Drawing.Point(3, 241);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(900, 28);
            this.progressBarDownload.TabIndex = 11;
            this.progressBarDownload.Visible = false;
            // 
            // checkBoxFits
            // 
            this.checkBoxFits.AutoSize = true;
            this.checkBoxFits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxFits.Location = new System.Drawing.Point(3, 173);
            this.checkBoxFits.Name = "checkBoxFits";
            this.checkBoxFits.Size = new System.Drawing.Size(114, 28);
            this.checkBoxFits.TabIndex = 13;
            this.checkBoxFits.Text = "FITS";
            this.checkBoxFits.UseVisualStyleBackColor = true;
            this.checkBoxFits.CheckedChanged += new System.EventHandler(this.CheckBoxFitsCheckedChanged);
            // 
            // checkBoxOverwritePictures
            // 
            this.checkBoxOverwritePictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOverwritePictures.Location = new System.Drawing.Point(659, 105);
            this.checkBoxOverwritePictures.Name = "checkBoxOverwritePictures";
            this.checkBoxOverwritePictures.Size = new System.Drawing.Size(119, 28);
            this.checkBoxOverwritePictures.TabIndex = 14;
            this.checkBoxOverwritePictures.Text = "Overwrite";
            this.checkBoxOverwritePictures.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverwriteFits
            // 
            this.checkBoxOverwriteFits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOverwriteFits.Enabled = false;
            this.checkBoxOverwriteFits.Location = new System.Drawing.Point(659, 173);
            this.checkBoxOverwriteFits.Name = "checkBoxOverwriteFits";
            this.checkBoxOverwriteFits.Size = new System.Drawing.Size(119, 28);
            this.checkBoxOverwriteFits.TabIndex = 15;
            this.checkBoxOverwriteFits.Text = "Overwrite";
            this.checkBoxOverwriteFits.UseVisualStyleBackColor = true;
            // 
            // comboBoxInformationFormat
            // 
            this.comboBoxInformationFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxInformationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInformationFormat.FormattingEnabled = true;
            this.comboBoxInformationFormat.Location = new System.Drawing.Point(784, 71);
            this.comboBoxInformationFormat.Name = "comboBoxInformationFormat";
            this.comboBoxInformationFormat.Size = new System.Drawing.Size(119, 29);
            this.comboBoxInformationFormat.TabIndex = 16;
            this.comboBoxInformationFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInformationFormatSelectedIndexChanged);
            // 
            // checkBoxJpeg
            // 
            this.checkBoxJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxJpeg.Location = new System.Drawing.Point(3, 139);
            this.checkBoxJpeg.Name = "checkBoxJpeg";
            this.checkBoxJpeg.Size = new System.Drawing.Size(114, 28);
            this.checkBoxJpeg.TabIndex = 18;
            this.checkBoxJpeg.Text = "JPEG";
            this.checkBoxJpeg.UseVisualStyleBackColor = true;
            this.checkBoxJpeg.CheckedChanged += new System.EventHandler(this.CheckBoxJpegCheckedChanged);
            // 
            // textBoxPatternJpeg
            // 
            this.textBoxPatternJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternJpeg.Enabled = false;
            this.textBoxPatternJpeg.Location = new System.Drawing.Point(123, 139);
            this.textBoxPatternJpeg.Name = "textBoxPatternJpeg";
            this.textBoxPatternJpeg.Size = new System.Drawing.Size(530, 29);
            this.textBoxPatternJpeg.TabIndex = 19;
            this.textBoxPatternJpeg.TextChanged += new System.EventHandler(this.TextBoxPatternJpegTextChanged);
            // 
            // textBoxPatternInformation
            // 
            this.textBoxPatternInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternInformation.Location = new System.Drawing.Point(123, 71);
            this.textBoxPatternInformation.Name = "textBoxPatternInformation";
            this.textBoxPatternInformation.Size = new System.Drawing.Size(530, 29);
            this.textBoxPatternInformation.TabIndex = 21;
            this.textBoxPatternInformation.TextChanged += new System.EventHandler(this.TextBoxPatternInformationTextChanged);
            // 
            // checkBoxOverwriteInformation
            // 
            this.checkBoxOverwriteInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOverwriteInformation.Location = new System.Drawing.Point(659, 71);
            this.checkBoxOverwriteInformation.Name = "checkBoxOverwriteInformation";
            this.checkBoxOverwriteInformation.Size = new System.Drawing.Size(119, 28);
            this.checkBoxOverwriteInformation.TabIndex = 22;
            this.checkBoxOverwriteInformation.Text = "Overwrite";
            this.checkBoxOverwriteInformation.UseVisualStyleBackColor = true;
            // 
            // checkBoxInformation
            // 
            this.checkBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxInformation.Location = new System.Drawing.Point(3, 71);
            this.checkBoxInformation.Name = "checkBoxInformation";
            this.checkBoxInformation.Size = new System.Drawing.Size(114, 28);
            this.checkBoxInformation.TabIndex = 23;
            this.checkBoxInformation.Text = "Information";
            this.checkBoxInformation.UseVisualStyleBackColor = true;
            this.checkBoxInformation.CheckedChanged += new System.EventHandler(this.CheckBoxInformationCheckedChanged);
            // 
            // checkBoxPictures
            // 
            this.checkBoxPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPictures.Location = new System.Drawing.Point(3, 105);
            this.checkBoxPictures.Name = "checkBoxPictures";
            this.checkBoxPictures.Size = new System.Drawing.Size(114, 28);
            this.checkBoxPictures.TabIndex = 24;
            this.checkBoxPictures.Text = "Pictures";
            this.checkBoxPictures.UseVisualStyleBackColor = true;
            this.checkBoxPictures.CheckedChanged += new System.EventHandler(this.CheckBoxPicturesCheckedChanged);
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelRight.ColumnCount = 3;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRight.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutPanelRight.Controls.Add(this.labelMemberSince, 1, 1);
            this.tableLayoutPanelRight.Controls.Add(this.labelTier, 1, 2);
            this.tableLayoutPanelRight.Controls.Add(this.labelGravityPoints, 1, 3);
            this.tableLayoutPanelRight.Controls.Add(this.labelNextTierPoints, 0, 4);
            this.tableLayoutPanelRight.Controls.Add(this.labelNextTier, 2, 4);
            this.tableLayoutPanelRight.Controls.Add(this.sloohProgressBar, 0, 5);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 7;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(278, 695);
            this.tableLayoutPanelRight.TabIndex = 0;
            // 
            // labelName
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.labelName, 2);
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(53, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(222, 30);
            this.labelName.TabIndex = 0;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberSince
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.labelMemberSince, 2);
            this.labelMemberSince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMemberSince.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMemberSince.Location = new System.Drawing.Point(53, 30);
            this.labelMemberSince.Name = "labelMemberSince";
            this.labelMemberSince.Size = new System.Drawing.Size(222, 30);
            this.labelMemberSince.TabIndex = 1;
            this.labelMemberSince.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTier
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.labelTier, 2);
            this.labelTier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTier.Location = new System.Drawing.Point(53, 60);
            this.labelTier.Name = "labelTier";
            this.labelTier.Size = new System.Drawing.Size(222, 30);
            this.labelTier.TabIndex = 2;
            this.labelTier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGravityPoints
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.labelGravityPoints, 2);
            this.labelGravityPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGravityPoints.Location = new System.Drawing.Point(53, 90);
            this.labelGravityPoints.Name = "labelGravityPoints";
            this.labelGravityPoints.Size = new System.Drawing.Size(222, 30);
            this.labelGravityPoints.TabIndex = 3;
            this.labelGravityPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNextTierPoints
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.labelNextTierPoints, 2);
            this.labelNextTierPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNextTierPoints.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNextTierPoints.Location = new System.Drawing.Point(3, 120);
            this.labelNextTierPoints.Name = "labelNextTierPoints";
            this.labelNextTierPoints.Size = new System.Drawing.Size(158, 30);
            this.labelNextTierPoints.TabIndex = 4;
            this.labelNextTierPoints.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelNextTier
            // 
            this.labelNextTier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNextTier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNextTier.Location = new System.Drawing.Point(167, 120);
            this.labelNextTier.Name = "labelNextTier";
            this.labelNextTier.Size = new System.Drawing.Size(108, 30);
            this.labelNextTier.TabIndex = 5;
            this.labelNextTier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sloohProgressBar
            // 
            this.tableLayoutPanelRight.SetColumnSpan(this.sloohProgressBar, 3);
            this.sloohProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sloohProgressBar.Location = new System.Drawing.Point(3, 153);
            this.sloohProgressBar.Name = "sloohProgressBar";
            this.sloohProgressBar.Size = new System.Drawing.Size(272, 9);
            this.sloohProgressBar.TabIndex = 7;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder where downloaded images are saved.";
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1188, 695);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMissions)).EndInit();
            this.contextMenuStripMissions.ResumeLayout(false);
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.tableLayoutPanelHeader.PerformLayout();
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMemberSince;
        private System.Windows.Forms.Label labelTier;
        private System.Windows.Forms.Label labelGravityPoints;
        private System.Windows.Forms.Label labelNextTierPoints;
        private System.Windows.Forms.Label labelNextTier;
        private SloohProgressBar sloohProgressBar;
        private SloohDataGridView gridMissions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxFolder;
        private SloohButton buttonSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelPatternMission;
        private System.Windows.Forms.TextBox textBoxPatternMission;
        private SloohButton buttonDownload;
        private System.Windows.Forms.TextBox textBoxPatternFits;
        private System.Windows.Forms.TextBox textBoxPatternPicture;
        private SloohProgressBar progressBarDownload;
        private System.Windows.Forms.CheckBox checkBoxFits;
        private System.Windows.Forms.CheckBox checkBoxOverwritePictures;
        private System.Windows.Forms.CheckBox checkBoxOverwriteFits;
        private System.Windows.Forms.ComboBox comboBoxInformationFormat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMissions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFolder;
        private System.Windows.Forms.CheckBox checkBoxJpeg;
        private System.Windows.Forms.TextBox textBoxPatternJpeg;
        private System.Windows.Forms.CheckBox checkBoxOverwriteJpeg;
        private System.Windows.Forms.TextBox textBoxPatternInformation;
        private System.Windows.Forms.CheckBox checkBoxOverwriteInformation;
        private System.Windows.Forms.CheckBox checkBoxInformation;
        private System.Windows.Forms.CheckBox checkBoxPictures;
        private Filtering.DataGridViewFilterDateTimeColumn ColumnTimestamp;
        private Filtering.DataGridViewFilterTextColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPicturesState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImageCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFits;
        private Filtering.DataGridViewFilterTextColumn ColumnTelescope;
        private Filtering.DataGridViewFilterTextColumn ColumnInstrument;
        private Filtering.DataGridViewFilterTextColumn ColumnOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
    }
}
