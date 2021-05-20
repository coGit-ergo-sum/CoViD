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

		public static Stopwatch stopwatch = new Stopwatch();


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

			if (Process.GetProcessesByName("Watcher").Length == 0)
			{
				var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
				var path = System.IO.Path.Combine(baseDirectory, "Watcher.exe");
				Process.Start(path);
				//System.Threading.Thread.Sleep(100);
				if (Process.GetProcessesByName("Watcher").Length == 0)
				{
					throw new System.Exception("Il programma 'Watcher' non è in esecuzione.");
				}
			}


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new CoViD.GUI.Plot());
			//Application.Run(new CoViD.GUI.Form1());
			//Application.Run(new GUI.Forms.Infection());
			//Application.Run(new CoViD.GUI.Butta.frmCircle());
			//Application.Run(new CoViD.GUI.Forms.Propagation());
			//Application.Run(new CoViD.GUI.Forms.Person());
			//Application.Run(new CoViD.GUI.Forms.MTI());

			//Application.Run(new CoViD.GUI.Form1());
			//Application.Run(new CoViD.GUI.Form2());
			//Application.Run(new CoViD.GUI.Form3());
			//Application.Run(new CoViD.GUI.Forms.MFI());

			//Application.Run(new CoViD.GUI.Forms.Spread());
			Application.Run(new CoViD.GUI.MDI());
		}
	}
}


