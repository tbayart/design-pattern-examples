using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public interface IPeople
    {
        string Name { get; set;}
        void Render(int depth);
    }
}
