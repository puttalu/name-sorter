using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    /// <summary>
    /// Class representing nane, first and last names
    /// </summary>
    public class Name
    {
        public string GivenName { get; }
        public string LastName { get; }

        public Name(string firstName, string lastName)
        {
            GivenName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Returns the full name combining Last and Given names
        /// </summary>
        /// <returns></returns>
        public string ToFullName()
        {
            return GivenName + " " + LastName;
        }
    }
}
