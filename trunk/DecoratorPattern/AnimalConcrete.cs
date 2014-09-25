using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class AnimalConcrete : AnimalBase
    {
        public override void operation()
        {
            Console.WriteLine("- I'm a animal and i can eat.");
        }
    }
}
