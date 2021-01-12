using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Controls
{
    internal partial class LogonControl : SloohControl
    {
        public LogonControl()
        {
            InitializeComponent();
        }

        public event EventHandler LoggedOn;

        protected override void OnSettingChanged()
        {
            base.OnSettingChanged();

            textBoxUser.Text = Setting?.Name;
            textBoxPassword.Text = Setting?.Password;
            checkBoxSavePassword.Checked = Setting?.SavePassword ?? false;
        }

        private void EnableLogon()
        {
            buttonLogon.Enabled = textBoxUser.Text.Length > 0 && textBoxPassword.Text.Length > 0;
        }

        private void TextBoxUserTextChanged(object sender, EventArgs e)
        {
            EnableLogon();
        }

        private void TextBoxPasswordTextChanged(object sender, EventArgs e)
        {
            EnableLogon();
        }

        private async void ButtonLogonClick(object sender, EventArgs e)
        {
            ParentForm.UseWaitCursor = true;
            try
            {
                SloohSite = new SloohSite
                {
                    Username = textBoxUser.Text,
                    Passwd = textBoxPassword.Text
                };

                await SloohSite.GetSessionToken();
                await SloohSite.Logon();

                Setting.Name = textBoxUser.Text;
                Setting.SavePassword = checkBoxSavePassword.Checked;
                if (Setting.SavePassword)
                {
                    Setting.Password = textBoxPassword.Text;
                }
                Setting.Save();

                LoggedOn?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                labelError.Text = exception.Message;                
            }
            finally
            {
                ParentForm.UseWaitCursor = false;
            }
        }

        private void ButtonQuitClick(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
