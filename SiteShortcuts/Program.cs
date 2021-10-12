using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace SiteShortcuts
{
    class Program
    {
        public static void Main() //
        {
            Console.WriteLine("Welcome to WebShortcuts");
            Thread.Sleep(5000);
            Console.WriteLine("Console WebShortcut tool");
            Thread.Sleep(5000);
            Console.WriteLine("Do you wanna to see availible shortcuts?");
            string doneedhelp = Console.ReadLine();
            doneedhelp = doneedhelp.ToUpper();
            doneedhelp = doneedhelp.Substring(0, 1);
            if (doneedhelp == Y)
            {
                Console.WriteLine(others.help);
            }
        }
    }
}