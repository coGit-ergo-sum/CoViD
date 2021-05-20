using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI.Tools
{
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
        }

        void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            // Occurs when the contents of the file change.
            MessageBox.Show(string.Format("Changed: {0} {1}", e.FullPath, e.ChangeType));
        }

        void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            // FullPath is the new file's path.
            MessageBox.Show(string.Format("Created: {0} {1}", e.FullPath, e.ChangeType));
        }

        void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            // FullPath is the location of where the file used to be.
            MessageBox.Show(string.Format("Deleted: {0} {1}", e.FullPath, e.ChangeType));
        }

        void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            // FullPath is the new file name.
            MessageBox.Show(string.Format("Renamed: {0} {1}", e.FullPath, e.ChangeType));
        }
    }
}
