using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    class DataGridViewFilterEditHeaderCell : DataGridViewFilterHeaderCell
    {
        public Regex Expression { get; set; }
        private TextBox EditBox { get; set; }
        private ToolTip ToolTip { get; set; }

        private string _filterError;
        protected string FilterError 
        { 
            get => _filterError;
            set 
            { 
                _filterError = value;
                ToolTip.SetToolTip(EditBox, _filterError);                    
            }
        }

        protected override void RelocateFilter(Rectangle rect)
        {
            base.RelocateFilter(rect);

            var editLeft = rect.Left + 2;
            var editWidth = rect.Width - 4;

            if (EditBox.Left == editLeft && EditBox.Width == editWidth) return;

            EditBox.Left = editLeft;
            EditBox.Top = rect.Bottom - EditBox.Height - 2;
            EditBox.Width = editWidth;
        }

        protected override void OnDataGridViewChanged()
        {
            if (DataGridView != null)
            {
                EditBox = new TextBox { Width = 100, Font = new Font(FontFamily.GenericSansSerif, 13f), Height = 20, BackColor = Color.DarkOliveGreen, HideSelection = true, ForeColor = Color.WhiteSmoke, BorderStyle = BorderStyle.None };
                EditBox.TextChanged += EditBoxTextChanged;
                DataGridView.Controls.Add(EditBox);

                ToolTip = new ToolTip
                {
                    ToolTipTitle = "Filter Error",
                    ToolTipIcon = ToolTipIcon.Error
                };

                ErrorText = "OK";
            }

            base.OnDataGridViewChanged();
        }

        private void EditBoxTextChanged(object sender, EventArgs e)
        {
            var match = Expression.Match(EditBox.Text);
            if (match.Success && SetFilter(match))
            {
                EditBox.BackColor = Color.DarkOliveGreen;
                FilterChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                EditBox.BackColor = Color.Red;
            }
        }

        protected virtual bool SetFilter(Match match)
        {
            return true;
        }
    }
}