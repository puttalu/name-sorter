
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSort
{
    /// <summary>
    /// Sort the names by last name and then by given namea
    /// </summary>
    public class NameSorter : INameSorter
    {
        /// <summary>
        /// sorts list of names
        /// </summary>
        /// <param name="names"></param>
        /// <returns>List of sorted names</returns>
        public List<Name> Sort(IEnumerable<Name> names)
        {
            return names.OrderBy(name => name.LastName).ThenBy(name => name.GivenName).ToList();
        }
    }
}
