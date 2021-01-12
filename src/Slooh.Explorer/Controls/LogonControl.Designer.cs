
namespace Slooh.Explorer.Controls
{
    partial class LogonControl
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxSavePassword = new System.Windows.Forms.CheckBox();
            this.buttonLogon = new Slooh.Explorer.Controls.SloohButton();
            this.buttonQuit = new Slooh.Explorer.Controls.SloohButton();
            this.labelError = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.35079F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.64921F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.64921F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.35079F));
            this.tableLayoutPanel.Controls.Add(this.labelUser, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelPassword, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxUser, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxPassword, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.checkBoxSavePassword, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonLogon, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.buttonQuit, 4, 4);
            this.tableLayoutPanel.Controls.Add(this.labelError, 2, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1081, 608);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUser.Location = new System.Drawing.Point(119, 224);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(185, 40);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(119, 264);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(185, 40);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUser
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxUser, 3);
            this.textBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUser.Location = new System.Drawing.Point(311, 227);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(650, 29);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.TextBoxUserTextChanged);
            // 
            // textBoxPassword
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxPassword, 3);
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(311, 267);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(650, 29);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPasswordTextChanged);
            // 
            // checkBoxSavePassword
            // 
            this.tableLayoutPanel.SetColumnSpan(this.checkBoxSavePassword, 3);
            this.checkBoxSavePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSavePassword.Location = new System.Drawing.Point(311, 307);
            this.checkBoxSavePassword.Name = "checkBoxSavePassword";
            this.checkBoxSavePassword.Size = new System.Drawing.Size(650, 34);
            this.checkBoxSavePassword.TabIndex = 3;
            this.checkBoxSavePassword.Text = "remember password";
            this.checkBoxSavePassword.UseVisualStyleBackColor = true;
            // 
            // buttonLogon
            // 
            this.buttonLogon.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogon.Enabled = false;
            this.buttonLogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogon.Location = new System.Drawing.Point(311, 347);
            this.buttonLogon.Name = "buttonLogon";
            this.buttonLogon.Size = new System.Drawing.Size(312, 34);
            this.buttonLogon.TabIndex = 4;
            this.buttonLogon.Text = "&Logon";
            this.buttonLogon.UseVisualStyleBackColor = false;
            this.buttonLogon.Click += new System.EventHandler(this.ButtonLogonClick);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonQuit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
            this.buttonQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(649, 347);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(312, 34);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "&Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuitClick);
            // 
            // labelError
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelError, 3);
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.Location = new System.Drawing.Point(311, 384);
            this.labelError.Name = "labelError";
            this.labelError.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelError.Size = new System.Drawing.Size(650, 201);
            this.labelError.TabIndex = 6;
            // 
            // LogonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogonControl";
            this.Size = new System.Drawing.Size(1081, 608);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxSavePassword;
        private SloohButton buttonLogon;
        private SloohButton buttonQuit;
        private System.Windows.Forms.Label labelError;
    }
}
