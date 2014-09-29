using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    public class Infantry : Unit
    {
        public static int NumberOfInstances;

        public Infantry()
        {
            NumberOfInstances++;
        }

        public override void FireAt(Target target)
        {
            Console.WriteLine("Attacking at enemy {0} with damage {1}.", target.ID, 
                Attack - target.UnitData.Defend);
        }
    }
}
