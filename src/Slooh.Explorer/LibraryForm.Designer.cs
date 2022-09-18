namespace Slooh.Explorer
{
    partial class LibraryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libraryControl = new Slooh.Explorer.Controls.LibraryControl();
            this.SuspendLayout();
            // 
            // libraryControl
            // 
            this.libraryControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.libraryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryControl.Folder = null;
            this.libraryControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.libraryControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.libraryControl.Location = new System.Drawing.Point(0, 0);
            this.libraryControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.libraryControl.Name = "libraryControl";
            this.libraryControl.Size = new System.Drawing.Size(1330, 759);
            this.libraryControl.TabIndex = 0;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 759);
            this.Controls.Add(this.libraryControl);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryFormFormClosed);
            this.Shown += new System.EventHandler(this.LibraryFormShown);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.LibraryControl libraryControl;
    }
}