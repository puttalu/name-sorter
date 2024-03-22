using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NameSort
{
    /// <summary>
    /// Parses the last name and given names from a full name
    /// </summary>
    public class NameParser : INameParser
    {
        /// <summary>
        /// Parese the name string to last and given names
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Name object with first and last names</returns>
        public Name Parse(string line)
        {
            var parts = line.Split(new[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
            string lastName = parts.Last();
            string firstName = parts.Length > 1 ? string.Join(" ", parts.Take(parts.Length - 1)) : "<<Invalid Name Format>>";
            return new Name(firstName, lastName);
        }
    }
}
