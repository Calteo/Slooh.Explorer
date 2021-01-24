using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Slooh.Explorer.Formats
{
    class InformationFormatterXml : InformationFormatter
    {
        public InformationFormatterXml() : base("XML", "xml")
        {
        }

        public override void Save(string missionFolder, Mission mission)
        {
            var document = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "true"),
                                    new XElement("mission",
                                        new XAttribute("title", mission.Title),
                                        new XAttribute("date",mission.Timestamp),
                                        new XAttribute("instrument", mission.Instrument),
                                        new XAttribute("telescope", mission.Telescope)
                                        )
                                    );

            
            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                NewLineHandling = NewLineHandling.Entitize,
                Indent = true,
            };

            using (var writer = XmlWriter.Create(GetFilename(missionFolder), settings))
            {
                document.WriteTo(writer);
            }
        }
    }
}
