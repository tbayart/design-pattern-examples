using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class PeopleDecorator : AnimalBase
    {
        private readonly AnimalBase m_animal;

        public PeopleDecorator(AnimalBase animal)
        {
            m_animal = animal;
        }

        public override void operation()
        {
            m_animal.operation();
        }
    }
}
