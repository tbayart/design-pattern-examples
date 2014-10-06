using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public interface IImageIterator
    {
        void MoveFirst();
        void Reset();
        bool MoveNext();
        ImageBase Current { get; }
    }
}
