using Slooh.Explorer.Filtering;
using System.Linq;
using System.Windows.Forms;
using Toolbox.Collection.Generics;

namespace Slooh.Explorer.Controls
{
    class SloohDataGridView : DataGridView
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Columns.Cast<DataGridViewColumn>()
                .Select(c => c.HeaderCell)
                .OfType<DataGridViewFilterHeaderCell>()
                .ForEach(h => h.Relocate());
        }
    }
}
