using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Slooh.Explorer.Xml
{
    internal static class XElementExtension
    {
        public static XAttribute RequiredAttribute(this XElement element, string name)
        {
            var attribute = element.Attribute(name);
            if (attribute == null)
            {
                var location = "";

                if (element is IXmlLineInfo lineInfo && lineInfo.HasLineInfo())
                {
                    location = $" at [{lineInfo.LineNumber}:{lineInfo.LinePosition}]";
                }

                throw new Exception($"Required attribute '{name}' missing on <{element.Name}>{location}.");
            }
            return attribute;            
        }
    }
}
