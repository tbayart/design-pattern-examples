using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public interface IImageEnumerable
    {
        IImageIterator GetIterator();
    }
}
