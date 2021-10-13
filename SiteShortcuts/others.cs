using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteShortcuts
{
    internal class others
    {
        public static void help()
        {
            Console.WriteLine();
            Console.WriteLine("List of availible shortcuts");
            Console.WriteLine("google        |      github");
            Console.WriteLine("spotify       |  newgrounds");
            Console.WriteLine("soundcloud    |     youtube");
            Console.WriteLine("discord       |       steam");
            Console.WriteLine();
        }

        public static void changelang()
        {
            Console.WriteLine();
            Console.WriteLine("Change to russian or english? (write Ru or En");
            string lang = Console.ReadLine();
            if (lang == "Ru")
            {
                language = web.Ru();
            }
            if (lang == "En")
            {
                language = web.En();
            }
            else
            {
                changelang();
            }
        }
    }
}
