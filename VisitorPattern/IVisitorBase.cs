using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public interface IVisitorBase
    {
        void Visit(Wheel wheel);
        void Visit(Body body);
    }
}
