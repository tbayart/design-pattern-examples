using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class PeopleConcrete : PeopleDecorator
    {
        public PeopleConcrete(AnimalBase animalBase)
            : base(animalBase)
        {

        }

        public override void operation()
        {
            base.operation();
            Console.WriteLine("+ I'm a person and i can  think!");
        }
    }
}
