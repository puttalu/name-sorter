using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public interface INameSorter
    {
        List<Name> Sort(IEnumerable<Name> names);
    }
}
