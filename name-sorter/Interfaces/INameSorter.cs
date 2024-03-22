using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    /// <summary>
    /// Interface for dsorting the list of names
    /// </summary>
    public interface INameSorter
    {
        /// <summary>
        /// Sort the list of names
        /// </summary>
        /// <param name="names"></param>
        /// <returns>List of sorted names</returns>
        List<Name> Sort(IEnumerable<Name> names);
    }
}
