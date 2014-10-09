using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class CarElementVisitor: IVisitorBase
    {
        public void Visit(Wheel wheel)
        {
            Console.WriteLine("Visit wheel {0}", wheel.Name);
        }

        public void Visit(Body body)
        {
            Console.WriteLine("Visit body {0}", body.Name);
        }
    }
}
