
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace NameSort
{
    /// <summary>
    /// Coordinates with all the components and gets the list sorted.
    /// </summary>
    public class NameSorterApp
    {
        private readonly INameParser _nameParser;
        private readonly INameSorter _nameSorter;

        private const string OutputFileName = "sorted-names-list.txt";

        public NameSorterApp(INameParser nameParser, INameSorter nameSorter)
        {
            _nameParser = nameParser;
            _nameSorter = nameSorter;
        }

        /// <summary>
        /// Runs NameSorterApp. File Name input is taken from argument in CLI.
        /// </summary>
        /// <param name="args"></param>
        public void Run(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid Argument. Please use the command format: name-sorter <filename>.txt");
                return;
            }

            string filename = args[0];

            try
            {
                var names = File.ReadAllLines(filename).Select(_nameParser.Parse);
                var sortedNames = _nameSorter.Sort(names);

                //Write The sorted list to output file and display on command line
                File.WriteAllLines(OutputFileName, sortedNames.Select(name => name.ToFullName()));

                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name.ToFullName());
                }

                Console.WriteLine($"\r\nSorted list of Names is written to >> {OutputFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
