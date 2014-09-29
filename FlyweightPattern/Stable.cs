using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    public class Stable: Unit
    {
        public static int NumberOfInstances;
        public Stable()
        {
            NumberOfInstances++;
        }

        public override void FireAt(Target target)
        {
            Console.WriteLine("Shooting at enemy {0} with damage {1}", target.ID, 
                Attack - target.UnitData.Defend);
        }
    }
}
