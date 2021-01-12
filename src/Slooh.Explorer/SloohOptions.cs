using System.ComponentModel;
using Toolbox.CommandLine;

namespace Slooh.Explorer
{
    class SloohOptions
    {
        [Option("trace"), DefaultValue(false), Description("Activates a trace window inside the application")]
        public bool Trace { get; set; }
    }
}
