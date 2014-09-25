using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    /// <summary>
    /// Extend the functionality of individual object. Here:
    /// - animalConcrete: individual object
    /// - peopleConcrete: extended object
    /// Ex: applyAlgorithm() in Lena
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var animalConcrete = new AnimalConcrete();
            var peopleConcrete = new PeopleConcrete(animalConcrete);
            peopleConcrete.operation();

            Console.ReadKey();
        }
    }
}
