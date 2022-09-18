using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Slooh.Explorer.Xml
{
    internal static class XContainerExtension
    {
        public static XElement RequiredElement(this XContainer container, string name)
        {
            var result = container.Element(name);
            if (result == null)
            {
                var location = "";

                if (container is IXmlLineInfo lineInfo && lineInfo.HasLineInfo())
                {
                    location = $" at [{lineInfo.LineNumber}:{lineInfo.LinePosition}]";
                }

                if (container is XElement parent)                  
                    throw new Exception($"Required element <{name}> missing on <{parent.Name}>{location}.");
                if (container is XDocument document)
                    throw new Exception($"Required element <{name}> missing as root element{location}.");

                throw new Exception($"Required element <{name}> missing{location}.");
            }
            return result;
        }
    }
}
