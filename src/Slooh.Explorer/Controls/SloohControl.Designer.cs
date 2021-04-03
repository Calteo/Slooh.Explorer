
namespace Slooh.Explorer.Controls
{
    partial class SloohControl
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
            this.helpProvider = new Toolbox.Help.WinForms.HelpProvider(this.components);
            this.SuspendLayout();
            // 
            // helpProvider
            // 
            this.helpProvider.HelpRequested += new System.EventHandler<Toolbox.Help.WinForms.HelpRequestedEventArgs>(this.HelpProviderHelpRequested);
            // 
            // SloohControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SloohControl";
            this.Size = new System.Drawing.Size(1000, 490);
            this.ResumeLayout(false);

        }

        #endregion

        protected Toolbox.Help.WinForms.HelpProvider helpProvider;
    }
}
