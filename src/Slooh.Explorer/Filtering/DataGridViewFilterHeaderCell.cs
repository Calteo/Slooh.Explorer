using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    class DataGridViewFilterHeaderCell : DataGridViewColumnHeaderCell
    {
        private FilterMode _mode = FilterMode.None;
        public FilterMode Mode 
        { 
            get => _mode;
            protected set
            {
                _mode = value;
                if (Button!=null)
                {
                    Button.Image = Filter.GetImage(Mode, Brushes.WhiteSmoke);
                    FilterChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        protected PictureBox Button { get; private set; }
        private ContextMenuStrip ContextMenu { get; set; }

        public EventHandler FilterChanged;
        

        public bool Accept(object item)
        {
            if (Mode == FilterMode.None) return true;

            var property = item.GetType().GetProperty(OwningColumn.DataPropertyName);
            var value = property.GetValue(item);

            return AcceptValue(value);
        }

        protected virtual bool AcceptValue(object value)
        {
            return false;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            RelocateFilter(DataGridView.GetCellDisplayRectangle(ColumnIndex, -1, true));
        }

        protected virtual void RelocateFilter(Rectangle rect)
        {
            var buttonLeft = rect.Right - Button.Width - 2;

            if (Button.Left == buttonLeft) return;

            Button.Left = buttonLeft;
            Button.Top = rect.Bottom - Button.Height - 2;
        }

        protected override void OnDataGridViewChanged()
        {
            base.OnDataGridViewChanged();

            if (DataGridView != null)
            {
                ContextMenu = new ContextMenuStrip();
                foreach (var mode in Enum.GetValues<FilterMode>())
                {
                    var item = new ToolStripMenuItem { Text = $"{mode}", Tag = mode };
                    ContextMenu.Items.Add(item);
                    item.Click += ModeClick;
                }

                ContextMenu.Items.Insert(ContextMenu.Items.Count - 1, new ToolStripSeparator());

                var image = Filter.GetImage(FilterMode.None, Brushes.WhiteSmoke);

                Button = new PictureBox { Width = 20, Height = 20, Image = image, BackColor = Color.DarkOliveGreen, SizeMode = PictureBoxSizeMode.CenterImage };
                Button.Click += ButtonClick;

                DataGridView.Controls.Add(Button);

                RelocateFilter(DataGridView.GetCellDisplayRectangle(ColumnIndex, -1, true));
            }
        }

        private void ModeClick(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            Mode = (FilterMode)item.Tag;                       
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            ContextMenu.Show(Cursor.Position);
        }
    }
}
