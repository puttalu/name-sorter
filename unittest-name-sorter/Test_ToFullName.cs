using NameSorter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace unittest_name_sorter
{
    public class Test_ToFullName
    {
        /// <summary>
        /// To Validate the capabilty to combine Last and Given names to make Full Name
        /// </summary>
        [Test]
        public void TestToFullName()
        {
            var name = new Name("Puttalu", "Maman");
            Assert.That(name.ToFullName(), Is.EqualTo("Puttalu Maman"));

        }
    }
}
