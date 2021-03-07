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
        public EventHandler FilterChanged;
        
        public bool Accept(object item)
        {
            var property = item.GetType().GetProperty(OwningColumn.DataPropertyName);
            var value = property.GetValue(item);

            return AcceptValue(value);
        }

        protected virtual bool AcceptValue(object value)
        {
            return true;
        }

        internal void Relocate()
        {
            RelocateFilter(DataGridView.GetCellDisplayRectangle(ColumnIndex, -1, true));
        }

        protected virtual void RelocateFilter(Rectangle rect)
        {
        }
    }
}
