using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    /// <summary>
    /// Copy shallow or deep an object
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Thread
            Scooter myScooter = new Scooter();
            myScooter.Power = "100";
            myScooter.Year = "2014";
            myScooter.Manufacter = new Manufacter("Sony", "Japan");

            Scooter yourScooter = (Scooter)myScooter.shallowCopy(); // Deep copy
            Scooter herScooter = (Scooter)myScooter.deepCopy(); // Shadow copy

            myScooter.Manufacter.Company = "LG";

            Console.WriteLine("Scooter: power {0}, year {1}, manufacter {2}", yourScooter.Power,
                yourScooter.Year, yourScooter.Manufacter.Company);
            Console.WriteLine("Scooter: power {0}, year {1}, manufacter {2}", herScooter.Power,
                herScooter.Year, herScooter.Manufacter.Company);

            Console.ReadKey();
        }
    }
}
