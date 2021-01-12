using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.CommandLine;

namespace Slooh.Explorer
{
    class SloohOptions
    {
        [Option("trace"), DefaultValue(false), Description("Activates a trace window inside the application")]
        public bool Trace { get; set; }
    }
}
