using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public interface INameParser
    {
        Name Parse(string line);
    }
}
