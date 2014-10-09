using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public interface IElementBase
    {
        void Accept(IVisitorBase visitor);
    }
}
