using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    public class DataGridViewFilterDateTimeColumn : DataGridViewTextBoxColumn
    {
        public DataGridViewFilterDateTimeColumn()
        {
            HeaderCell = new DataGridViewFilterDateTimeHeaderCell();
        }    
     }
}
