using NameSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace unittest_name_sorter
{
    public class Test_NameSorter_Exceptions
    {
        private NameSorterApp _nameSorterApp;
        private StringWriter _stringWriter;

        [SetUp]
        public void Setup()
        {
            _nameSorterApp = new NameSorterApp(new NameParser(), new NameSorter());
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        /// <summary>
        /// Custom error message is displayed when there is not file name passed in the arguments.
        /// </summary>
        [Test]
        public void TestRunNoArguments()
        {
            _nameSorterApp.Run(new string[0]);
            Assert.That(_stringWriter.ToString(), Is.EqualTo("Invalid Argument. Please use the command format: name-sorter <filename>.txt\r\n"));
        }

        /// <summary>
        /// To validate the exception thrown if the inputfile does not exist
        /// </summary>
        [Test]
        public void TestInvlidFileException()
        {
            _nameSorterApp.Run(new[] { "invalidFile.txt" });
            StringAssert.StartsWith("Error: Could not find file", _stringWriter.ToString());
        }
    }
}
