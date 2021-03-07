using Slooh.Explorer.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    class DataGridViewFilterTextHeaderCell : DataGridViewFilterHeaderCell
    {
        private string FilterText => EditBox?.Text;
        private TextBox EditBox { get; set; }

        protected override void RelocateFilter(Rectangle rect)
        {
            base.RelocateFilter(rect);

            var editLeft = rect.Left + 2;
            var editWidth = Button.Left - 2 - EditBox.Left;

            if (EditBox.Left==editLeft && EditBox.Width==editWidth) return;

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
            }

            base.OnDataGridViewChanged();
        }

        private void EditBoxTextChanged(object sender, EventArgs e)
        {
            if (Mode == FilterMode.None)
            {
                Mode = FilterMode.Contains;
            }

            FilterChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override bool AcceptValue(object value)
        {
            var text = (string)value;

            switch (Mode)
            {
                case FilterMode.Equals:
                    return text == FilterText;
                case FilterMode.NotEquals:
                    return text != FilterText;
                case FilterMode.Contains:
                    return text.Contains(FilterText);
                case FilterMode.Begins:
                    return text.StartsWith(FilterText);                    
                case FilterMode.Ends:
                    return text.EndsWith(FilterText);                    
                case FilterMode.Less:
                    return text.CompareTo(FilterText) < 0;
                case FilterMode.LessEqual:
                    return text.CompareTo(FilterText) <= 0;
                case FilterMode.Greater:
                    return text.CompareTo(FilterText) > 0;                    
                case FilterMode.GreaterEqual:
                    return text.CompareTo(FilterText) >= 0;                    
                default:
                    return false;
            }
        }
    }
}