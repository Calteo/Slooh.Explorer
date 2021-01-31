using System.IO;

namespace Slooh.Explorer.Formats
{
    abstract class InformationFormatter
    {
        public InformationFormatter(string name, string extension)
        {
            Name = name;
            Extension = extension;
        }

        public string Name { get; }

        public string Extension { get; }

        public abstract void Save(string missionFolder, Mission mission);
    }
}
