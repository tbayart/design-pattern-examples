using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    public abstract class Unit
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Attack { get; set; }
        public int Defend { get; set; }
        public int Range { get; set; }
        public abstract void FireAt(Target target);
    }
}
