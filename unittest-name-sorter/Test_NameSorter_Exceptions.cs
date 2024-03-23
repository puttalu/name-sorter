using NameSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace unittest_name_sorter
{
    public class Test_NameSorter_Exceptions
    {
        private NameSorterApp _nameSorterApp;
        private StringWriter _stringWriter;
        private string _test_InputFile;
        private string _test_OutputFile;

        [SetUp]
        public void Setup()
        {
            _nameSorterApp = new NameSorterApp(new NameParser(), new NameSorter());
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);

            _test_InputFile = create_test_inputfile();
            _test_OutputFile = "sorted-names-list.txt";
        }

        /// <summary>
        /// Delete the temp files created by test case: TestInputFile_With_EmptyLines
        /// </summary>
        [TearDown]        
        public void Teardown()
        {
            File.Delete(_test_InputFile);
            File.Delete(_test_OutputFile);
        }

        /// <summary>
        /// Create input file for test case: TestInputFile_With_EmptyLines
        /// </summary>
        /// <returns></returns>
        private string create_test_inputfile()
        {
            var _testFileName = "inputFile_With_EmptyLines.txt";
            var inputLines = new[]
            {
                "Vikraman Kallan",
                "",
                "Puttalu Maman"
            };
            File.WriteAllLines( _testFileName, inputLines );
            return _testFileName;
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

        /// <summary>
        /// To validate if the code can handle empty lines in the input file
        /// </summary>
        [Test]
        public void TestInputFile_With_EmptyLines()
        {
            var args = new[] { _test_InputFile };

            _nameSorterApp.Run(args);

            StringAssert.DoesNotStartWith("Error: Sequence contains no elements", _stringWriter.ToString());
        }
    }
}
