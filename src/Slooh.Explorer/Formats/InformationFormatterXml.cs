using System.Linq;
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

        public override void Save(string filename, Mission mission)
        {
            var document = new XDocument(
                                new XDeclaration("1.0", "utf-8", "true"),
                                new XElement("mission",
                                    new XAttribute("title", mission.Title),
                                    new XAttribute("date",mission.Timestamp),
                                    new XAttribute("telescope", mission.Telescope),
                                    new XAttribute("instrument", mission.Instrument),                                    
                                    new XElement("pictures",
                                        mission.Pictures.Select(p =>
                                            new XElement("picture",
                                                new XAttribute("date", p.Timestamp),                                                
                                                new XAttribute("telescope", p.Telescope),
                                                new XAttribute("instrument", p.Instrument),
                                                new XAttribute("filename", p.Filename)
                                            )
                                        )
                                    ),
                                    new XElement("fits",
                                        mission.FitsPictures.Select(p =>
                                            new XElement("picture",
                                                new XAttribute("date", p.Timestamp),
                                                new XAttribute("telescope", p.Telescope),
                                                new XAttribute("instrument", p.Instrument),
                                                new XAttribute("filename", p.Filename)
                                            )
                                        )
                                    )
                                )
                            );

            var settings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                NewLineHandling = NewLineHandling.Entitize,
                Indent = true,
            };

            using (var writer = XmlWriter.Create(filename, settings))
            {
                document.WriteTo(writer);
            }
        }
    }
}
