using NameSort;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace unittest_name_sorter
{
    public class Test_NameSorter_Sorting
    {
        private NameSorter _nameSorter;

        [SetUp]
        public void Setup()
        {
            _nameSorter = new NameSorter();
        }

        /// <summary>
        /// To validate the sorting functionality. Input: Unsorted list of names, Output: Sorted LIst.
        /// </summary>
        [Test]
        public void TestSortNames()
        {
            var unsortedNames = new List<Name>
            {
                new Name("Adonis Julius", "Archer"),
                new Name("Marin", "Alvarez"),
                new Name("Hunter Uriah Mathew", "Clarke"),
                new Name("Beau Tristan", "Bentley")
            };

            var expectedSortOutput = new List<Name>
            {
                new Name("Marin", "Alvarez"),
                new Name("Adonis Julius", "Archer"),
                new Name("Beau Tristan", "Bentley"),
                new Name("Hunter Uriah Mathew", "Clarke")
            };

            var sortedNames = _nameSorter.Sort(unsortedNames);

            Assert.That(sortedNames[0].ToFullName(), Is.EqualTo(expectedSortOutput[0].ToFullName()));
            Assert.That(sortedNames[1].ToFullName(), Is.EqualTo(expectedSortOutput[1].ToFullName()));
            Assert.That(sortedNames[2].ToFullName(), Is.EqualTo(expectedSortOutput[2].ToFullName()));
            Assert.That(sortedNames[3].ToFullName(), Is.EqualTo(expectedSortOutput[3].ToFullName()));
        }
    }
}
