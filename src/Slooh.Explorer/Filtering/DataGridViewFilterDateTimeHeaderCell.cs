using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer.Filtering
{
    class DataGridViewFilterDateTimeHeaderCell : DataGridViewFilterEditHeaderCell
    {
        public DataGridViewFilterDateTimeHeaderCell()
        {
            Expression = new Regex(@"^(?<operator>>=|<=|<|>)?(?<text>.*)", RegexOptions.Compiled);
        }

        string Operator { get; set; }
        private DateTime Timestamp { get; set; }

        protected override bool SetFilter(Match match)
        {
            Operator = null;

            if (match.Groups["text"].Success)
            {
                var text = match.Groups["text"].Value;

                if (text != "")
                {
                    if (!DateTime.TryParse(text, out var time))
                    {
                        FilterError = "No valid date entered.";
                        return false;
                    }

                    Timestamp = time;
                    FilterError = "";

                    if (match.Groups["operator"].Success)
                        Operator = match.Groups["operator"].Value;
                    else
                        Operator = "";
                }
            }

            return true;
        }

        protected override bool AcceptValue(object value)
        {
            var timestamp = (DateTime)value;

            if (Operator == null) return true;

            var isDate = Timestamp.Date == Timestamp;

            switch (Operator)
            {
                case "<":                   
                    return isDate ? timestamp.Date < Timestamp : timestamp < Timestamp;
                case "<=":
                    return isDate ? timestamp.Date <= Timestamp : timestamp <= Timestamp;
                case ">":
                    return isDate ? timestamp.Date > Timestamp : timestamp > Timestamp;
                case ">=":
                    return isDate ? timestamp.Date >= Timestamp : timestamp >= Timestamp;
                default:
                    return isDate ? Timestamp == timestamp.Date : Timestamp == timestamp;
            }
        }
    }   
}