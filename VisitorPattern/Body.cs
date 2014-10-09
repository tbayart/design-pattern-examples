using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class Body: IElementBase
    {
        public string Name { get; set; }

        public Body(string name)
        {
            Name = name;
        }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
