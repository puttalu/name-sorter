using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class NameParser : INameParser
    {
        public Name Parse(string line)
        {
            var parts = line.Split(new[] { ' ' }, 4, StringSplitOptions.RemoveEmptyEntries);
            string lastName = parts.Last();
            string firstName = parts.Length > 1 ? string.Join(" ", parts.Take(parts.Length - 1)) : "##NoGivenName##";
            return new Name(firstName, lastName);
        }
    }
}
