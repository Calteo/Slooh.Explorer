using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    public class DataGridViewFilterTextColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewFilterTextColumn()
        {
            HeaderCell = new DataGridViewFilterTextHeaderCell();           
        }             
    }
}
