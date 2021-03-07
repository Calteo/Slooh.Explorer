using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Slooh.Explorer.Filtering
{
    class DataGridViewFilterTextHeaderCell : DataGridViewFilterEditHeaderCell
    {
        public DataGridViewFilterTextHeaderCell()
        {
            Expression = new Regex(@"^(?<operator>=|<=|>=|>|<)?(?<text>.*)", RegexOptions.Compiled);
        }

        private string Operator { get; set; } = "";
        private string Text { get; set; } = "";
        private Regex Pattern { get; set; }

        protected override bool SetFilter(Match match)
        {
            if (match.Groups["operator"].Success)
                Operator = match.Groups["operator"].Value;
            else
                Operator = "";

            if (match.Groups["text"].Success)
            {
                Text = match.Groups["text"].Value;
                if (Operator == "")
                {
                    try
                    {
                        if (!Text.StartsWith("*") && !Text.EndsWith("*"))
                            Text = "*" + Text + "*";

                        var patternText = Text.Replace(".", "\\.").Replace("*", ".*")
                                    .Replace("?", ".").Replace("(", "\\(").Replace(")", "\\)");

                        Pattern = new Regex("^" + patternText + "$");
                        FilterError = "";
                    }
                    catch (Exception exception)
                    {
                        FilterError = exception.Message;
                        return false;
                    }
                }
                else
                {
                    Pattern = null;
                }
            }
            else
            {
                Text = "";
            }

            return true;
        }

        protected override bool AcceptValue(object value)
        {
            var text = (string)value;

            if (Text == "") return true;

            switch (Operator)
            {
                case "=":
                    return text == Text;
                case "<":
                    return text.CompareTo(Text) < 0;
                case "<=":
                    return text.CompareTo(Text) <= 0;
                case ">":
                    return text.CompareTo(Text) > 0;
                case ">=":
                    return text.CompareTo(Text) >= 0;
                default:
                    return Pattern?.IsMatch(text) ?? false;
            }            
        }
    }
}
