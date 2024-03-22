using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    /// <summary>
    /// Interface for parsing name string to last and given names
    /// </summary>
    public interface INameParser
    {
        /// <summary>
        /// Parses the name string to last and given names. 
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Name object with last and first names</returns>
        Name Parse(string line);
    }
}
