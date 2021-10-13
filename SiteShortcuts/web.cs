using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SiteShortcuts
{
    internal class web
    {
        public static void En()
        {
            Console.WriteLine();
            Console.WriteLine("Write shortcut name:");
            string shrtctName = Console.ReadLine();
            if (shrtctName == "google")
            {
                Process.Start("http://google.com");
            }
            if (shrtctName == "soundcloud")
            {
                Process.Start("http://soundcloud.com");
            }

            else
            {
                Console.WriteLine("Missing Shortcut");
            }
        }
    }
}
