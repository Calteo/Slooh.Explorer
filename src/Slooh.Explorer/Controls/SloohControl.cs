using System.ComponentModel;
using System.Windows.Forms;
using Toolbox.Help.WinForms;

namespace Slooh.Explorer.Controls
{
    internal partial class SloohControl : UserControl
    {
        private SloohUserSetting setting;
        private SloohSite sloohSite;

        public SloohControl()
        {
            InitializeComponent();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SloohUserSetting Setting
        {
            get => setting;
            set
            {
                setting = value;
                OnSettingChanged();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SloohSite SloohSite 
        { 
            get => sloohSite;
            set 
            { 
                sloohSite = value;
                OnSloohSiteChanged();
            }
        }

        protected virtual void OnSloohSiteChanged()
        {
        }

        protected virtual void OnSettingChanged()
        {
        }

        private void HelpProviderHelpRequested(object sender, HelpRequestedEventArgs e)
        {
            SingletonHelpForm.Navigate(e.Url);
        }
    }
}
