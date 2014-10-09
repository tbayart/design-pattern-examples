using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class Car: IElementBase
    {
        private readonly List<IElementBase> m_parts;

        public Car()
        {
            m_parts = new List<IElementBase> 
            {
                new Wheel("Front"),
                new Body("4-door sedan")
            };
        }

        public void Accept(IVisitorBase visitor)
        {
            foreach (var part in m_parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
