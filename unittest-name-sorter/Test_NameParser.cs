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

        /// <summary>
        /// To validate the flagging of invalid names. When there is only first or last name present.
        /// </summary>
        [Test]
        public void TestParse_When_InvalidName()
        {
            var name = _nameParser.Parse("Puttalu");

            Assert.That(name.GivenName, Is.EqualTo("<<Invalid Name Format>>"));
            Assert.That(name.LastName, Is.EqualTo("Puttalu"));

        }
    }
}
