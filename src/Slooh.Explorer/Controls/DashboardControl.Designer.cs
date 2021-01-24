
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
            this.gridMissions = new System.Windows.Forms.DataGridView();
            this.ColumnTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPicturesState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFits = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTelescope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInstrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripMissions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPatternFits = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPatternPicture = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new Slooh.Explorer.Controls.SloohButton();
            this.labelPatternMission = new System.Windows.Forms.Label();
            this.textBoxPatternMission = new System.Windows.Forms.TextBox();
            this.buttonDownload = new Slooh.Explorer.Controls.SloohButton();
            this.progressBarDownload = new Slooh.Explorer.Controls.SloohProgressBar();
            this.labelPicture = new System.Windows.Forms.Label();
            this.checkBoxFits = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwritePictures = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwriteFits = new System.Windows.Forms.CheckBox();
            this.comboBoxInformationFormat = new System.Windows.Forms.ComboBox();
            this.labelInformation = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridMissions);
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelRight);
            this.splitContainer.Size = new System.Drawing.Size(1082, 595);
            this.splitContainer.SplitterDistance = 800;
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.gridMissions.Location = new System.Drawing.Point(0, 195);
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
            this.gridMissions.Size = new System.Drawing.Size(800, 400);
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
            this.ColumnTimestamp.Width = 66;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTitle.DataPropertyName = "Title";
            this.ColumnTitle.Frozen = true;
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            this.ColumnTitle.Width = 63;
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
            // 
            // ColumnInstrument
            // 
            this.ColumnInstrument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnInstrument.DataPropertyName = "Instrument";
            this.ColumnInstrument.HeaderText = "Instrument";
            this.ColumnInstrument.Name = "ColumnInstrument";
            this.ColumnInstrument.ReadOnly = true;
            this.ColumnInstrument.Width = 110;
            // 
            // ColumnOwner
            // 
            this.ColumnOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOwner.DataPropertyName = "Owner";
            this.ColumnOwner.HeaderText = "Owner";
            this.ColumnOwner.Name = "ColumnOwner";
            this.ColumnOwner.ReadOnly = true;
            this.ColumnOwner.Width = 62;
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel.Controls.Add(this.textBoxPatternFits, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxPatternPicture, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelFolder, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxFolder, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonSelectFolder, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelPatternMission, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxPatternMission, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonDownload, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.progressBarDownload, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelPicture, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.checkBoxFits, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.checkBoxOverwritePictures, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.checkBoxOverwriteFits, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.comboBoxInformationFormat, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.labelInformation, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 195);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // textBoxPatternFits
            // 
            this.textBoxPatternFits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternFits.Enabled = false;
            this.textBoxPatternFits.Location = new System.Drawing.Point(123, 105);
            this.textBoxPatternFits.Name = "textBoxPatternFits";
            this.textBoxPatternFits.Size = new System.Drawing.Size(424, 29);
            this.textBoxPatternFits.TabIndex = 10;
            this.textBoxPatternFits.TextChanged += new System.EventHandler(this.TextBoxPatternFitsTextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(678, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 28);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // textBoxPatternPicture
            // 
            this.textBoxPatternPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPatternPicture.Location = new System.Drawing.Point(123, 71);
            this.textBoxPatternPicture.Name = "textBoxPatternPicture";
            this.textBoxPatternPicture.Size = new System.Drawing.Size(424, 29);
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
            this.textBoxFolder.Size = new System.Drawing.Size(424, 29);
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
            this.buttonSelectFolder.Location = new System.Drawing.Point(553, 3);
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
            this.textBoxPatternMission.Size = new System.Drawing.Size(424, 29);
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
            this.buttonDownload.Location = new System.Drawing.Point(678, 139);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(119, 28);
            this.buttonDownload.TabIndex = 5;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownloadClick);
            // 
            // progressBarDownload
            // 
            this.tableLayoutPanel.SetColumnSpan(this.progressBarDownload, 4);
            this.progressBarDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarDownload.Location = new System.Drawing.Point(3, 173);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(794, 19);
            this.progressBarDownload.TabIndex = 11;
            this.progressBarDownload.Visible = false;
            // 
            // labelPicture
            // 
            this.labelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPicture.Location = new System.Drawing.Point(3, 68);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(114, 34);
            this.labelPicture.TabIndex = 12;
            this.labelPicture.Text = "Picture";
            this.labelPicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxFits
            // 
            this.checkBoxFits.AutoSize = true;
            this.checkBoxFits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxFits.Location = new System.Drawing.Point(3, 105);
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
            this.checkBoxOverwritePictures.Location = new System.Drawing.Point(553, 71);
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
            this.checkBoxOverwriteFits.Location = new System.Drawing.Point(553, 105);
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
            this.comboBoxInformationFormat.Location = new System.Drawing.Point(678, 37);
            this.comboBoxInformationFormat.Name = "comboBoxInformationFormat";
            this.comboBoxInformationFormat.Size = new System.Drawing.Size(119, 29);
            this.comboBoxInformationFormat.TabIndex = 16;
            // 
            // labelInformation
            // 
            this.labelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInformation.Location = new System.Drawing.Point(553, 34);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(119, 34);
            this.labelInformation.TabIndex = 17;
            this.labelInformation.Text = "Information";
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(278, 595);
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
            this.Size = new System.Drawing.Size(1082, 595);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMissions)).EndInit();
            this.contextMenuStripMissions.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView gridMissions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox textBoxFolder;
        private SloohButton buttonSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelPatternMission;
        private System.Windows.Forms.TextBox textBoxPatternMission;
        private SloohButton buttonDownload;
        private System.Windows.Forms.TextBox textBoxPatternFits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPatternPicture;
        private SloohProgressBar progressBarDownload;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.CheckBox checkBoxFits;
        private System.Windows.Forms.CheckBox checkBoxOverwritePictures;
        private System.Windows.Forms.CheckBox checkBoxOverwriteFits;
        private System.Windows.Forms.ComboBox comboBoxInformationFormat;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMissions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPicturesState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImageCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelescope;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
    }
}
