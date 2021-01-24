using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooh.Explorer.Formats
{
    class InformationFormatterNone : InformationFormatter
    {
        public InformationFormatterNone() : base("None", "")
        {
        }

        public override void Save(string missionFolder, Mission mission)
        {
            // we do nothing here
        }
    }
}
