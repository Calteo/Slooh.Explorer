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

        protected string GetFilename(string missionFolder)
        {
            return Path.Combine(missionFolder, $"information.{Extension}");
        }

        public abstract void Save(string missionFolder, Mission mission);
    }
}
