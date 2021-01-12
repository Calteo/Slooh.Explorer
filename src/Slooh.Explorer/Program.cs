using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolbox.CommandLine;

namespace Slooh.Explorer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var parser = Parser.Create<SloohOptions>();
            var result = parser.Parse(args);

            var rc = result
                        .OnError(OnError)
                        .OnHelp(OnHelp)
                        .On<SloohOptions>(OnRun)
                        .Return;
                                
            return rc;
        }

        private static int OnRun(SloohOptions options)
        {
            Application.Run(new MainForm { Options = options });
            return 0;
        }

        private static int OnHelp(ParseResult result)
        {
            MessageBox.Show(result.GetHelpText(), "Slooh Explorer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 2;
        }

        private static int OnError(ParseResult result)
        {
            MessageBox.Show(result.Text, "Slooh Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 2;
        }
    }
}
