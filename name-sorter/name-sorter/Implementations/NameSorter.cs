
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorter
{
    public class NameSorter : INameSorter
    {
        public List<Name> Sort(IEnumerable<Name> names)
        {
            return names.OrderBy(name => name.LastName).ThenBy(name => name.GivenName).ToList();
        }
    }
}
