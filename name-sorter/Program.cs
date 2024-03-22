
using System;

namespace NameSort
{
    internal class Program
    {       
       
        /// <summary>
        /// Entry point of execution of the program
        /// Main method gets the filename as argument from CLI
        /// </summary>
        public static void Main(string[] args)
        {
            var app = new NameSorterApp(new NameParser(), new NameSorter());
            app.Run(args);

        }
    }
}
