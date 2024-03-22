using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class Name
    {
        public string GivenName { get; }
        public string LastName { get; }

        public Name(string firstName, string lastName)
        {
            GivenName = firstName;
            LastName = lastName;
        }


        public string ToFullName()
        {
            return GivenName + " " + LastName;
        }
    }
}
