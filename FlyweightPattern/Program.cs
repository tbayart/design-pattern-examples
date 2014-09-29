using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// - When very large numbers of objects
    /// - Object same structure 
    /// - Ex: Ages Of Empires: The Expansion game
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            UnitFactory factory = new UnitFactory();

            var axeman1 = new Target();
            axeman1.ID = Guid.NewGuid();
            axeman1.UnitData = factory.GetUnit("Axeman");

            var axeman2 = new Target();
            axeman2.ID = Guid.NewGuid();
            axeman2.UnitData = factory.GetUnit("Axeman");
            Console.WriteLine("Number of axeman: {0}", Infantry.NumberOfInstances);

            var cavalry1 = new Target();
            cavalry1.ID = Guid.NewGuid();
            cavalry1.UnitData = factory.GetUnit("Cavalry");

            cavalry1.UnitData.FireAt(axeman1);

            var cavalry2 = new Target();
            cavalry2.ID = Guid.NewGuid();
            cavalry2.UnitData = factory.GetUnit("Chariot");
            var cavalry3 = new Target();
            cavalry3.ID = Guid.NewGuid();
            cavalry3.UnitData = factory.GetUnit("Cavalry");
            Console.WriteLine("Number of cavalry: {0}", Stable.NumberOfInstances);

            Console.ReadKey();
        }
    }
}
