using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class Wheel: IElementBase 
    {
        public string Name { get; set; }

        public Wheel(string name)
        {
            Name = name;
        }

        public void Accept(IVisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
