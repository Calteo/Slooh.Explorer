
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            splitContainer = new System.Windows.Forms.SplitContainer();
            tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            gridMissions = new SloohDataGridView();
            ColumnTimestamp = new Filtering.DataGridViewFilterDateTimeColumn();
            ColumnTitle = new Filtering.DataGridViewFilterTextColumn();
            ColumnPicturesState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnImageCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnFits = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ColumnTelescope = new Filtering.DataGridViewFilterTextColumn();
            ColumnInstrument = new Filtering.DataGridViewFilterTextColumn();
            ColumnOwner = new Filtering.DataGridViewFilterTextColumn();
            ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contextMenuStripMissions = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItemOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            checkBoxOverwriteJpeg = new System.Windows.Forms.CheckBox();
            textBoxPatternFits = new System.Windows.Forms.TextBox();
            textBoxPatternPicture = new System.Windows.Forms.TextBox();
            labelFolder = new System.Windows.Forms.Label();
            textBoxFolder = new System.Windows.Forms.TextBox();
            buttonSelectFolder = new SloohButton();
            labelPatternMission = new System.Windows.Forms.Label();
            textBoxPatternMission = new System.Windows.Forms.TextBox();
            buttonDownload = new SloohButton();
            progressBarDownload = new SloohProgressBar();
            checkBoxFits = new System.Windows.Forms.CheckBox();
            checkBoxOverwritePictures = new System.Windows.Forms.CheckBox();
            checkBoxOverwriteFits = new System.Windows.Forms.CheckBox();
            comboBoxInformationFormat = new System.Windows.Forms.ComboBox();
            checkBoxJpeg = new System.Windows.Forms.CheckBox();
            textBoxPatternJpeg = new System.Windows.Forms.TextBox();
            textBoxPatternInformation = new System.Windows.Forms.TextBox();
            checkBoxOverwriteInformation = new System.Windows.Forms.CheckBox();
            checkBoxInformation = new System.Windows.Forms.CheckBox();
            checkBoxPictures = new System.Windows.Forms.CheckBox();
            buttonBrowse = new SloohButton();
            buttonFetch = new SloohButton();
            upDownStart = new System.Windows.Forms.NumericUpDown();
            labelStart = new System.Windows.Forms.Label();
            labelLimit = new System.Windows.Forms.Label();
            upDownLimit = new System.Windows.Forms.NumericUpDown();
            checkBoxCaptures = new System.Windows.Forms.CheckBox();
            checkBoxMissions = new System.Windows.Forms.CheckBox();
            tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            labelName = new System.Windows.Forms.Label();
            labelMemberSince = new System.Windows.Forms.Label();
            labelTier = new System.Windows.Forms.Label();
            labelGravityPoints = new System.Windows.Forms.Label();
            labelNextTierPoints = new System.Windows.Forms.Label();
            labelNextTier = new System.Windows.Forms.Label();
            sloohProgressBar = new SloohProgressBar();
            thumbnailsControl = new ThumbnailsControl();
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMissions).BeginInit();
            contextMenuStripMissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownLimit).BeginInit();
            tableLayoutPanelRight.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Margin = new System.Windows.Forms.Padding(4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(tableLayoutPanelHeader);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelRight);
            splitContainer.Size = new System.Drawing.Size(1621, 927);
            splitContainer.SplitterDistance = 1285;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanelHeader
            // 
            tableLayoutPanelHeader.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanelHeader.ColumnCount = 9;
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            tableLayoutPanelHeader.Controls.Add(gridMissions, 0, 9);
            tableLayoutPanelHeader.Controls.Add(checkBoxOverwriteJpeg, 7, 4);
            tableLayoutPanelHeader.Controls.Add(textBoxPatternFits, 1, 5);
            tableLayoutPanelHeader.Controls.Add(textBoxPatternPicture, 1, 3);
            tableLayoutPanelHeader.Controls.Add(labelFolder, 0, 0);
            tableLayoutPanelHeader.Controls.Add(textBoxFolder, 1, 0);
            tableLayoutPanelHeader.Controls.Add(buttonSelectFolder, 7, 0);
            tableLayoutPanelHeader.Controls.Add(labelPatternMission, 0, 1);
            tableLayoutPanelHeader.Controls.Add(textBoxPatternMission, 1, 1);
            tableLayoutPanelHeader.Controls.Add(buttonDownload, 8, 6);
            tableLayoutPanelHeader.Controls.Add(progressBarDownload, 0, 7);
            tableLayoutPanelHeader.Controls.Add(checkBoxFits, 0, 5);
            tableLayoutPanelHeader.Controls.Add(checkBoxOverwritePictures, 7, 3);
            tableLayoutPanelHeader.Controls.Add(checkBoxOverwriteFits, 7, 5);
            tableLayoutPanelHeader.Controls.Add(comboBoxInformationFormat, 8, 2);
            tableLayoutPanelHeader.Controls.Add(checkBoxJpeg, 0, 4);
            tableLayoutPanelHeader.Controls.Add(textBoxPatternJpeg, 1, 4);
            tableLayoutPanelHeader.Controls.Add(textBoxPatternInformation, 1, 2);
            tableLayoutPanelHeader.Controls.Add(checkBoxOverwriteInformation, 7, 2);
            tableLayoutPanelHeader.Controls.Add(checkBoxInformation, 0, 2);
            tableLayoutPanelHeader.Controls.Add(checkBoxPictures, 0, 3);
            tableLayoutPanelHeader.Controls.Add(buttonBrowse, 8, 0);
            tableLayoutPanelHeader.Controls.Add(buttonFetch, 8, 8);
            tableLayoutPanelHeader.Controls.Add(upDownStart, 1, 8);
            tableLayoutPanelHeader.Controls.Add(labelStart, 0, 8);
            tableLayoutPanelHeader.Controls.Add(labelLimit, 2, 8);
            tableLayoutPanelHeader.Controls.Add(upDownLimit, 3, 8);
            tableLayoutPanelHeader.Controls.Add(checkBoxCaptures, 6, 8);
            tableLayoutPanelHeader.Controls.Add(checkBoxMissions, 5, 8);
            tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            tableLayoutPanelHeader.RowCount = 9;
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanelHeader.Size = new System.Drawing.Size(1285, 927);
            tableLayoutPanelHeader.TabIndex = 1;
            // 
            // gridMissions
            // 
            gridMissions.AllowUserToAddRows = false;
            gridMissions.AllowUserToDeleteRows = false;
            gridMissions.AllowUserToResizeRows = false;
            gridMissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            gridMissions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            gridMissions.BackgroundColor = System.Drawing.Color.FromArgb(44, 57, 68);
            gridMissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gridMissions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(44, 57, 68);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(50, 70, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridMissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridMissions.ColumnHeadersHeight = 60;
            gridMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridMissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnTimestamp, ColumnTitle, ColumnPicturesState, ColumnImageCount, ColumnFits, ColumnTelescope, ColumnInstrument, ColumnOwner, ColumnState });
            tableLayoutPanelHeader.SetColumnSpan(gridMissions, 9);
            gridMissions.ContextMenuStrip = contextMenuStripMissions;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            gridMissions.DefaultCellStyle = dataGridViewCellStyle8;
            gridMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            gridMissions.EnableHeadersVisualStyles = false;
            helpProvider.SetHelpUrl(gridMissions, "images.html");
            gridMissions.Location = new System.Drawing.Point(4, 409);
            gridMissions.Margin = new System.Windows.Forms.Padding(4);
            gridMissions.Name = "gridMissions";
            gridMissions.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridMissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            gridMissions.RowHeadersVisible = false;
            gridMissions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(50, 70, 94);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(179, 145, 87);
            gridMissions.RowsDefaultCellStyle = dataGridViewCellStyle10;
            gridMissions.RowTemplate.Height = 25;
            gridMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridMissions.ShowEditingIcon = false;
            gridMissions.Size = new System.Drawing.Size(1277, 514);
            gridMissions.TabIndex = 0;
            gridMissions.CellFormatting += GridMissionsCellFormatting;
            gridMissions.SelectionChanged += GridMissionsSelectionChanged;
            // 
            // ColumnTimestamp
            // 
            ColumnTimestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnTimestamp.DataPropertyName = "Timestamp";
            ColumnTimestamp.Frozen = true;
            ColumnTimestamp.HeaderText = "Date";
            ColumnTimestamp.MinimumWidth = 6;
            ColumnTimestamp.Name = "ColumnTimestamp";
            ColumnTimestamp.ReadOnly = true;
            ColumnTimestamp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColumnTimestamp.Width = 150;
            // 
            // ColumnTitle
            // 
            ColumnTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnTitle.DataPropertyName = "Title";
            ColumnTitle.Frozen = true;
            ColumnTitle.HeaderText = "Title";
            ColumnTitle.MinimumWidth = 6;
            ColumnTitle.Name = "ColumnTitle";
            ColumnTitle.ReadOnly = true;
            ColumnTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColumnTitle.Width = 250;
            // 
            // ColumnPicturesState
            // 
            ColumnPicturesState.DataPropertyName = "PicturesState";
            ColumnPicturesState.Frozen = true;
            ColumnPicturesState.HeaderText = "P";
            ColumnPicturesState.MinimumWidth = 6;
            ColumnPicturesState.Name = "ColumnPicturesState";
            ColumnPicturesState.ReadOnly = true;
            ColumnPicturesState.Width = 51;
            // 
            // ColumnImageCount
            // 
            ColumnImageCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnImageCount.DataPropertyName = "ImageCount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            ColumnImageCount.DefaultCellStyle = dataGridViewCellStyle7;
            ColumnImageCount.Frozen = true;
            ColumnImageCount.HeaderText = "Images";
            ColumnImageCount.MinimumWidth = 6;
            ColumnImageCount.Name = "ColumnImageCount";
            ColumnImageCount.ReadOnly = true;
            ColumnImageCount.Width = 84;
            // 
            // ColumnFits
            // 
            ColumnFits.DataPropertyName = "HasFits";
            ColumnFits.HeaderText = "FITS";
            ColumnFits.MinimumWidth = 6;
            ColumnFits.Name = "ColumnFits";
            ColumnFits.ReadOnly = true;
            ColumnFits.Width = 53;
            // 
            // ColumnTelescope
            // 
            ColumnTelescope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnTelescope.DataPropertyName = "Telescope";
            ColumnTelescope.HeaderText = "Telescope";
            ColumnTelescope.MinimumWidth = 6;
            ColumnTelescope.Name = "ColumnTelescope";
            ColumnTelescope.ReadOnly = true;
            ColumnTelescope.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColumnTelescope.Width = 125;
            // 
            // ColumnInstrument
            // 
            ColumnInstrument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnInstrument.DataPropertyName = "Instrument";
            ColumnInstrument.HeaderText = "Instrument";
            ColumnInstrument.MinimumWidth = 6;
            ColumnInstrument.Name = "ColumnInstrument";
            ColumnInstrument.ReadOnly = true;
            ColumnInstrument.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColumnInstrument.Width = 110;
            // 
            // ColumnOwner
            // 
            ColumnOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnOwner.DataPropertyName = "Owner";
            ColumnOwner.HeaderText = "Owner";
            ColumnOwner.MinimumWidth = 6;
            ColumnOwner.Name = "ColumnOwner";
            ColumnOwner.ReadOnly = true;
            ColumnOwner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ColumnOwner.Width = 150;
            // 
            // ColumnState
            // 
            ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            ColumnState.DataPropertyName = "State";
            ColumnState.HeaderText = "State";
            ColumnState.MinimumWidth = 6;
            ColumnState.Name = "ColumnState";
            ColumnState.ReadOnly = true;
            ColumnState.Width = 125;
            // 
            // contextMenuStripMissions
            // 
            contextMenuStripMissions.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStripMissions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemOpenFolder, toolStripMenuItemDelete });
            contextMenuStripMissions.Name = "contextMenuStripMissions";
            contextMenuStripMissions.Size = new System.Drawing.Size(170, 52);
            contextMenuStripMissions.Opening += ContextMenuStripMissionsOpening;
            // 
            // toolStripMenuItemOpenFolder
            // 
            toolStripMenuItemOpenFolder.Name = "toolStripMenuItemOpenFolder";
            toolStripMenuItemOpenFolder.Size = new System.Drawing.Size(169, 24);
            toolStripMenuItemOpenFolder.Text = "Open Folder...";
            toolStripMenuItemOpenFolder.Click += ToolStripMenuItemOpenFolderClick;
            // 
            // toolStripMenuItemDelete
            // 
            toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            toolStripMenuItemDelete.Size = new System.Drawing.Size(169, 24);
            toolStripMenuItemDelete.Text = "Delete";
            toolStripMenuItemDelete.Click += ToolStripMenuItemDeleteClick;
            // 
            // checkBoxOverwriteJpeg
            // 
            checkBoxOverwriteJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxOverwriteJpeg.Enabled = false;
            checkBoxOverwriteJpeg.Location = new System.Drawing.Point(983, 184);
            checkBoxOverwriteJpeg.Margin = new System.Windows.Forms.Padding(4);
            checkBoxOverwriteJpeg.Name = "checkBoxOverwriteJpeg";
            checkBoxOverwriteJpeg.Size = new System.Drawing.Size(145, 37);
            checkBoxOverwriteJpeg.TabIndex = 20;
            checkBoxOverwriteJpeg.Text = "Overwrite";
            checkBoxOverwriteJpeg.UseVisualStyleBackColor = true;
            // 
            // textBoxPatternFits
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxPatternFits, 6);
            textBoxPatternFits.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxPatternFits.Enabled = false;
            textBoxPatternFits.Location = new System.Drawing.Point(152, 230);
            textBoxPatternFits.Margin = new System.Windows.Forms.Padding(5);
            textBoxPatternFits.Name = "textBoxPatternFits";
            textBoxPatternFits.Size = new System.Drawing.Size(822, 34);
            textBoxPatternFits.TabIndex = 10;
            textBoxPatternFits.TextChanged += TextBoxPatternFitsTextChanged;
            // 
            // textBoxPatternPicture
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxPatternPicture, 6);
            textBoxPatternPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxPatternPicture.Location = new System.Drawing.Point(152, 140);
            textBoxPatternPicture.Margin = new System.Windows.Forms.Padding(5);
            textBoxPatternPicture.Name = "textBoxPatternPicture";
            textBoxPatternPicture.Size = new System.Drawing.Size(822, 34);
            textBoxPatternPicture.TabIndex = 8;
            textBoxPatternPicture.TextChanged += TextBoxPatternPictureTextChanged;
            // 
            // labelFolder
            // 
            labelFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFolder.Location = new System.Drawing.Point(5, 0);
            labelFolder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelFolder.Name = "labelFolder";
            labelFolder.Size = new System.Drawing.Size(137, 45);
            labelFolder.TabIndex = 0;
            labelFolder.Text = "Folder";
            labelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFolder
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxFolder, 6);
            textBoxFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            helpProvider.SetHelpUrl(textBoxFolder, "options.html");
            textBoxFolder.Location = new System.Drawing.Point(152, 5);
            textBoxFolder.Margin = new System.Windows.Forms.Padding(5);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.Size = new System.Drawing.Size(822, 34);
            textBoxFolder.TabIndex = 1;
            textBoxFolder.TextChanged += TextBoxFolderTextChanged;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.BackColor = System.Drawing.Color.Transparent;
            buttonSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSelectFolder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            buttonSelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(194, 160, 104);
            buttonSelectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 52, 70);
            buttonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpProvider.SetHelpUrl(buttonSelectFolder, "options.html");
            buttonSelectFolder.Location = new System.Drawing.Point(983, 4);
            buttonSelectFolder.Margin = new System.Windows.Forms.Padding(4);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new System.Drawing.Size(145, 37);
            buttonSelectFolder.TabIndex = 2;
            buttonSelectFolder.Text = "Select";
            buttonSelectFolder.UseVisualStyleBackColor = false;
            buttonSelectFolder.Click += ButtonSelectFolderClick;
            // 
            // labelPatternMission
            // 
            labelPatternMission.Dock = System.Windows.Forms.DockStyle.Fill;
            labelPatternMission.Location = new System.Drawing.Point(5, 45);
            labelPatternMission.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelPatternMission.Name = "labelPatternMission";
            labelPatternMission.Size = new System.Drawing.Size(137, 45);
            labelPatternMission.TabIndex = 3;
            labelPatternMission.Text = "Mission";
            labelPatternMission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPatternMission
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxPatternMission, 6);
            textBoxPatternMission.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxPatternMission.Location = new System.Drawing.Point(152, 50);
            textBoxPatternMission.Margin = new System.Windows.Forms.Padding(5);
            textBoxPatternMission.Name = "textBoxPatternMission";
            textBoxPatternMission.Size = new System.Drawing.Size(822, 34);
            textBoxPatternMission.TabIndex = 4;
            textBoxPatternMission.TextChanged += TextBoxPatternMissionTextChanged;
            // 
            // buttonDownload
            // 
            buttonDownload.BackColor = System.Drawing.Color.Transparent;
            buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonDownload.Enabled = false;
            buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(194, 160, 104);
            buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 52, 70);
            buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDownload.Location = new System.Drawing.Point(1136, 274);
            buttonDownload.Margin = new System.Windows.Forms.Padding(4);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new System.Drawing.Size(145, 37);
            buttonDownload.TabIndex = 5;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += ButtonDownloadClick;
            // 
            // progressBarDownload
            // 
            tableLayoutPanelHeader.SetColumnSpan(progressBarDownload, 9);
            progressBarDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            progressBarDownload.Location = new System.Drawing.Point(4, 319);
            progressBarDownload.Margin = new System.Windows.Forms.Padding(4);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new System.Drawing.Size(1277, 37);
            progressBarDownload.TabIndex = 11;
            progressBarDownload.Visible = false;
            // 
            // checkBoxFits
            // 
            checkBoxFits.AutoSize = true;
            checkBoxFits.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxFits.Location = new System.Drawing.Point(4, 229);
            checkBoxFits.Margin = new System.Windows.Forms.Padding(4);
            checkBoxFits.Name = "checkBoxFits";
            checkBoxFits.Size = new System.Drawing.Size(139, 37);
            checkBoxFits.TabIndex = 13;
            checkBoxFits.Text = "FITS";
            checkBoxFits.UseVisualStyleBackColor = true;
            checkBoxFits.CheckedChanged += CheckBoxFitsCheckedChanged;
            // 
            // checkBoxOverwritePictures
            // 
            checkBoxOverwritePictures.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxOverwritePictures.Location = new System.Drawing.Point(983, 139);
            checkBoxOverwritePictures.Margin = new System.Windows.Forms.Padding(4);
            checkBoxOverwritePictures.Name = "checkBoxOverwritePictures";
            checkBoxOverwritePictures.Size = new System.Drawing.Size(145, 37);
            checkBoxOverwritePictures.TabIndex = 14;
            checkBoxOverwritePictures.Text = "Overwrite";
            checkBoxOverwritePictures.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverwriteFits
            // 
            checkBoxOverwriteFits.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxOverwriteFits.Enabled = false;
            checkBoxOverwriteFits.Location = new System.Drawing.Point(983, 229);
            checkBoxOverwriteFits.Margin = new System.Windows.Forms.Padding(4);
            checkBoxOverwriteFits.Name = "checkBoxOverwriteFits";
            checkBoxOverwriteFits.Size = new System.Drawing.Size(145, 37);
            checkBoxOverwriteFits.TabIndex = 15;
            checkBoxOverwriteFits.Text = "Overwrite";
            checkBoxOverwriteFits.UseVisualStyleBackColor = true;
            // 
            // comboBoxInformationFormat
            // 
            comboBoxInformationFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBoxInformationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxInformationFormat.FormattingEnabled = true;
            comboBoxInformationFormat.Location = new System.Drawing.Point(1136, 94);
            comboBoxInformationFormat.Margin = new System.Windows.Forms.Padding(4);
            comboBoxInformationFormat.Name = "comboBoxInformationFormat";
            comboBoxInformationFormat.Size = new System.Drawing.Size(145, 36);
            comboBoxInformationFormat.TabIndex = 16;
            comboBoxInformationFormat.SelectedIndexChanged += ComboBoxInformationFormatSelectedIndexChanged;
            // 
            // checkBoxJpeg
            // 
            checkBoxJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxJpeg.Location = new System.Drawing.Point(4, 184);
            checkBoxJpeg.Margin = new System.Windows.Forms.Padding(4);
            checkBoxJpeg.Name = "checkBoxJpeg";
            checkBoxJpeg.Size = new System.Drawing.Size(139, 37);
            checkBoxJpeg.TabIndex = 18;
            checkBoxJpeg.Text = "JPEG";
            checkBoxJpeg.UseVisualStyleBackColor = true;
            checkBoxJpeg.CheckedChanged += CheckBoxJpegCheckedChanged;
            // 
            // textBoxPatternJpeg
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxPatternJpeg, 6);
            textBoxPatternJpeg.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxPatternJpeg.Enabled = false;
            textBoxPatternJpeg.Location = new System.Drawing.Point(152, 185);
            textBoxPatternJpeg.Margin = new System.Windows.Forms.Padding(5);
            textBoxPatternJpeg.Name = "textBoxPatternJpeg";
            textBoxPatternJpeg.Size = new System.Drawing.Size(822, 34);
            textBoxPatternJpeg.TabIndex = 19;
            textBoxPatternJpeg.TextChanged += TextBoxPatternJpegTextChanged;
            // 
            // textBoxPatternInformation
            // 
            tableLayoutPanelHeader.SetColumnSpan(textBoxPatternInformation, 6);
            textBoxPatternInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxPatternInformation.Location = new System.Drawing.Point(152, 95);
            textBoxPatternInformation.Margin = new System.Windows.Forms.Padding(5);
            textBoxPatternInformation.Name = "textBoxPatternInformation";
            textBoxPatternInformation.Size = new System.Drawing.Size(822, 34);
            textBoxPatternInformation.TabIndex = 21;
            textBoxPatternInformation.TextChanged += TextBoxPatternInformationTextChanged;
            // 
            // checkBoxOverwriteInformation
            // 
            checkBoxOverwriteInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxOverwriteInformation.Location = new System.Drawing.Point(983, 94);
            checkBoxOverwriteInformation.Margin = new System.Windows.Forms.Padding(4);
            checkBoxOverwriteInformation.Name = "checkBoxOverwriteInformation";
            checkBoxOverwriteInformation.Size = new System.Drawing.Size(145, 37);
            checkBoxOverwriteInformation.TabIndex = 22;
            checkBoxOverwriteInformation.Text = "Overwrite";
            checkBoxOverwriteInformation.UseVisualStyleBackColor = true;
            // 
            // checkBoxInformation
            // 
            checkBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxInformation.Location = new System.Drawing.Point(4, 94);
            checkBoxInformation.Margin = new System.Windows.Forms.Padding(4);
            checkBoxInformation.Name = "checkBoxInformation";
            checkBoxInformation.Size = new System.Drawing.Size(139, 37);
            checkBoxInformation.TabIndex = 23;
            checkBoxInformation.Text = "Information";
            checkBoxInformation.UseVisualStyleBackColor = true;
            checkBoxInformation.CheckedChanged += CheckBoxInformationCheckedChanged;
            // 
            // checkBoxPictures
            // 
            checkBoxPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxPictures.Location = new System.Drawing.Point(4, 139);
            checkBoxPictures.Margin = new System.Windows.Forms.Padding(4);
            checkBoxPictures.Name = "checkBoxPictures";
            checkBoxPictures.Size = new System.Drawing.Size(139, 37);
            checkBoxPictures.TabIndex = 24;
            checkBoxPictures.Text = "Pictures";
            checkBoxPictures.UseVisualStyleBackColor = true;
            checkBoxPictures.CheckedChanged += CheckBoxPicturesCheckedChanged;
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = System.Drawing.Color.Transparent;
            buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            buttonBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(194, 160, 104);
            buttonBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 52, 70);
            buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBrowse.Location = new System.Drawing.Point(1136, 4);
            buttonBrowse.Margin = new System.Windows.Forms.Padding(4);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new System.Drawing.Size(145, 37);
            buttonBrowse.TabIndex = 25;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += ButtonBrowseClick;
            // 
            // buttonFetch
            // 
            buttonFetch.BackColor = System.Drawing.Color.Transparent;
            buttonFetch.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonFetch.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            buttonFetch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(194, 160, 104);
            buttonFetch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(27, 52, 70);
            buttonFetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonFetch.Location = new System.Drawing.Point(1135, 363);
            buttonFetch.Name = "buttonFetch";
            buttonFetch.Size = new System.Drawing.Size(147, 39);
            buttonFetch.TabIndex = 26;
            buttonFetch.Text = "Fetch";
            buttonFetch.UseVisualStyleBackColor = false;
            buttonFetch.Click += ButtonRefreshClick;
            // 
            // upDownStart
            // 
            upDownStart.Dock = System.Windows.Forms.DockStyle.Fill;
            upDownStart.Location = new System.Drawing.Point(150, 363);
            upDownStart.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            upDownStart.Name = "upDownStart";
            upDownStart.Size = new System.Drawing.Size(147, 34);
            upDownStart.TabIndex = 27;
            upDownStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            upDownStart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStart
            // 
            labelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            labelStart.Location = new System.Drawing.Point(3, 360);
            labelStart.Name = "labelStart";
            labelStart.Size = new System.Drawing.Size(141, 45);
            labelStart.TabIndex = 28;
            labelStart.Text = "Start";
            labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLimit
            // 
            labelLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            labelLimit.Location = new System.Drawing.Point(303, 360);
            labelLimit.Name = "labelLimit";
            labelLimit.Size = new System.Drawing.Size(147, 45);
            labelLimit.TabIndex = 29;
            labelLimit.Text = "Limit";
            labelLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upDownLimit
            // 
            upDownLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            upDownLimit.Location = new System.Drawing.Point(456, 363);
            upDownLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            upDownLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            upDownLimit.Name = "upDownLimit";
            upDownLimit.Size = new System.Drawing.Size(147, 34);
            upDownLimit.TabIndex = 30;
            upDownLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            upDownLimit.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // checkBoxCaptures
            // 
            checkBoxCaptures.AutoSize = true;
            checkBoxCaptures.Checked = true;
            checkBoxCaptures.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCaptures.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxCaptures.Location = new System.Drawing.Point(812, 363);
            checkBoxCaptures.Name = "checkBoxCaptures";
            checkBoxCaptures.Size = new System.Drawing.Size(164, 39);
            checkBoxCaptures.TabIndex = 32;
            checkBoxCaptures.Text = "Captures (?)";
            checkBoxCaptures.UseVisualStyleBackColor = true;
            // 
            // checkBoxMissions
            // 
            checkBoxMissions.AutoSize = true;
            checkBoxMissions.Checked = true;
            checkBoxMissions.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            checkBoxMissions.Location = new System.Drawing.Point(642, 363);
            checkBoxMissions.Name = "checkBoxMissions";
            checkBoxMissions.Size = new System.Drawing.Size(164, 39);
            checkBoxMissions.TabIndex = 33;
            checkBoxMissions.Text = "Missions (?)";
            checkBoxMissions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanelRight.ColumnCount = 3;
            tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelRight.Controls.Add(labelName, 1, 0);
            tableLayoutPanelRight.Controls.Add(labelMemberSince, 1, 1);
            tableLayoutPanelRight.Controls.Add(labelTier, 1, 2);
            tableLayoutPanelRight.Controls.Add(labelGravityPoints, 1, 3);
            tableLayoutPanelRight.Controls.Add(labelNextTierPoints, 0, 4);
            tableLayoutPanelRight.Controls.Add(labelNextTier, 2, 4);
            tableLayoutPanelRight.Controls.Add(sloohProgressBar, 0, 5);
            tableLayoutPanelRight.Controls.Add(thumbnailsControl, 0, 6);
            tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelRight.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelRight.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 7;
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelRight.Size = new System.Drawing.Size(331, 927);
            tableLayoutPanelRight.TabIndex = 0;
            // 
            // labelName
            // 
            tableLayoutPanelRight.SetColumnSpan(labelName, 2);
            labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(65, 0);
            labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(262, 40);
            labelName.TabIndex = 0;
            labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMemberSince
            // 
            tableLayoutPanelRight.SetColumnSpan(labelMemberSince, 2);
            labelMemberSince.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMemberSince.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMemberSince.Location = new System.Drawing.Point(65, 40);
            labelMemberSince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMemberSince.Name = "labelMemberSince";
            labelMemberSince.Size = new System.Drawing.Size(262, 40);
            labelMemberSince.TabIndex = 1;
            labelMemberSince.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelTier
            // 
            tableLayoutPanelRight.SetColumnSpan(labelTier, 2);
            labelTier.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTier.Location = new System.Drawing.Point(66, 80);
            labelTier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelTier.Name = "labelTier";
            labelTier.Size = new System.Drawing.Size(260, 40);
            labelTier.TabIndex = 2;
            labelTier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGravityPoints
            // 
            tableLayoutPanelRight.SetColumnSpan(labelGravityPoints, 2);
            labelGravityPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            labelGravityPoints.Location = new System.Drawing.Point(66, 120);
            labelGravityPoints.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelGravityPoints.Name = "labelGravityPoints";
            labelGravityPoints.Size = new System.Drawing.Size(260, 40);
            labelGravityPoints.TabIndex = 3;
            labelGravityPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNextTierPoints
            // 
            tableLayoutPanelRight.SetColumnSpan(labelNextTierPoints, 2);
            labelNextTierPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNextTierPoints.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNextTierPoints.Location = new System.Drawing.Point(4, 160);
            labelNextTierPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNextTierPoints.Name = "labelNextTierPoints";
            labelNextTierPoints.Size = new System.Drawing.Size(188, 40);
            labelNextTierPoints.TabIndex = 4;
            labelNextTierPoints.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelNextTier
            // 
            labelNextTier.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNextTier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNextTier.Location = new System.Drawing.Point(200, 160);
            labelNextTier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNextTier.Name = "labelNextTier";
            labelNextTier.Size = new System.Drawing.Size(127, 40);
            labelNextTier.TabIndex = 5;
            labelNextTier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // sloohProgressBar
            // 
            tableLayoutPanelRight.SetColumnSpan(sloohProgressBar, 3);
            sloohProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            sloohProgressBar.Location = new System.Drawing.Point(4, 204);
            sloohProgressBar.Margin = new System.Windows.Forms.Padding(4);
            sloohProgressBar.Name = "sloohProgressBar";
            sloohProgressBar.Size = new System.Drawing.Size(323, 12);
            sloohProgressBar.TabIndex = 7;
            // 
            // thumbnailsControl
            // 
            thumbnailsControl.BackColor = System.Drawing.Color.FromArgb(50, 70, 94);
            tableLayoutPanelRight.SetColumnSpan(thumbnailsControl, 3);
            thumbnailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            thumbnailsControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            thumbnailsControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            thumbnailsControl.Location = new System.Drawing.Point(5, 225);
            thumbnailsControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            thumbnailsControl.Name = "thumbnailsControl";
            thumbnailsControl.Size = new System.Drawing.Size(321, 697);
            thumbnailsControl.TabIndex = 8;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.Description = "Select folder where downloaded images are saved.";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(37, 52, 70);
            Controls.Add(splitContainer);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "DashboardControl";
            Size = new System.Drawing.Size(1621, 927);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelHeader.ResumeLayout(false);
            tableLayoutPanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridMissions).EndInit();
            contextMenuStripMissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)upDownStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownLimit).EndInit();
            tableLayoutPanelRight.ResumeLayout(false);
            ResumeLayout(false);
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
        private ThumbnailsControl thumbnailsControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private SloohButton buttonBrowse;
        private SloohButton buttonFetch;
        private System.Windows.Forms.NumericUpDown upDownStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.NumericUpDown upDownLimit;
        private System.Windows.Forms.CheckBox checkBoxCaptures;
        private System.Windows.Forms.CheckBox checkBoxMissions;
    }
}
