using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    public class DataGridViewFilterIntegerColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewFilterIntegerColumn()
        {
            HeaderCell = new DataGridViewFilterIntegerHeaderCell();
        }

    }
}
