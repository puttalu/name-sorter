using NameSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace unittest_name_sorter
{
    public class Test_NameParser
    {
        private NameParser _nameParser;

        [SetUp]
        public void Setup()
        {
            _nameParser = new NameParser();
        }

        /// <summary>
        /// To validate the capability to split Last and Given Names
        /// </summary>
        [Test]
        public void TestParseName()
        {
            var name = _nameParser.Parse("Puttalu Vikraman Maman");

            Assert.That(name.GivenName, Is.EqualTo("Puttalu Vikraman"));
            Assert.That(name.LastName, Is.EqualTo("Maman"));

        }
    }
}
