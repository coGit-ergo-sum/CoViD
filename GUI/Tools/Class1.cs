using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoViD.GUI.Tools
{



	public static class Watcher
	{
		/// <summary>
		/// Watcher. Butta
		/// </summary>
		static FileSystemWatcher _watcher;


        /// <summary>
        /// Init.
        /// </summary>
        static void Init()
        {
            Console.WriteLine("INIT");
            string directory = @"C:\programs\";
            Watcher._watcher = new FileSystemWatcher(directory);
            Watcher._watcher.Changed += new FileSystemEventHandler(Watcher._watcher_Changed);
            Watcher._watcher.EnableRaisingEvents = true;
            Watcher._watcher.IncludeSubdirectories = true;
        }

        /// <summary>
        /// Handler.
        /// </summary>
        static void _watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("CHANGED, NAME: " + e.Name);
            Console.WriteLine("CHANGED, FULLPATH: " + e.FullPath);
            // Can change program state (set invalid state) in this method.
            // ... Better to use insensitive compares for file names.
        }


    }
}
