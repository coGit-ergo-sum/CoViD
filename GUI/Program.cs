using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vi.Tools.Extensions.Float;


namespace CoViD
{
	static class Program
	{
		public const string Name = "Program";
		public static Stopwatch stopwatch = new Stopwatch();
		///////////////public static Vi.Tools.Profile profile;
		public static Vi.Tools.Profile INICoViD; 
		public static Vi.Tools.Profile INIGUI;


		static Brush red = (Brush)Brushes.Red;
		static Brush black = (Brush)Brushes.Black;
		static Brush white = (Brush)Brushes.White;
		static Brush green = (Brush)Brushes.Lime;
		static Brush yellow = (Brush)Brushes.Yellow;
		static Brush orange = (Brush)Brushes.Orange;
		static Brush blue = (Brush)Brushes.Blue;
		static Brush darkRed = (Brush)Brushes.DarkRed;
		static Brush gray = new SolidBrush(Color.FromArgb(50, 50, 50));

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

			////////////var fileName = System.IO.Path.Combine(baseDirectory, "Settings.ini");
			var fileNameCoViD = System.IO.Path.Combine(baseDirectory, "CoViD.ini");
			var fileNameGUI = System.IO.Path.Combine(baseDirectory, "GUI.ini");

			////////////Program.profile = new Vi.Tools.Profile(fileName);
			Program.INIGUI = new Vi.Tools.Profile(fileNameGUI);
			Program.INICoViD = new Vi.Tools.Profile(fileNameCoViD);

			if (baseDirectory.ToUpper().StartsWith(@"c:\vi\code".ToUpper())){

				// Whatcher is a tool to backup all the changes made to the code, 
				// every time the application starts
				if (Process.GetProcessesByName("Watcher").Length == 0)
				{
					var path = System.IO.Path.Combine(baseDirectory, "Watcher.exe");
					if (System.IO.File.Exists(path))
					{
						var watcher = Process.Start(path);
						if (Process.GetProcessesByName("Watcher").Length == 0)
						{
							throw new System.Exception("'Watcher' is not running.");
						}
					}
				}
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new CoViD.GUI.Forms.Person());
			//Application.Run(new GUI.Forms.Infection());
			Application.Run(new CoViD.GUI.Forms.Spread());
		}
	}
}


