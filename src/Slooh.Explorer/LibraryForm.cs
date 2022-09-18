using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooh.Explorer
{
    internal partial class LibraryForm : Form
    {
        private string _folder;

        public LibraryForm()
        {
            InitializeComponent();
        }
        
        public string Folder
        {
            get => _folder;
            set
            {
                libraryControl.Folder = _folder = value;                             

                Text = $"Library - {_folder}";
            }
        }

        private void LibraryFormShown(object sender, EventArgs e)
        {
            libraryControl.Scan();
        }

        private void LibraryFormFormClosed(object sender, FormClosedEventArgs e)
        {
            libraryControl.TokenSource?.Cancel();
        }
    }
}
