using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// The strategy pattern is a design pattern that allows a set of
    /// similar algorithms to be defined and encapsulated in their own classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                TestController testController = new TestController();
                Console.WriteLine(testController.isGood().ToString());
            }
            Console.ReadKey();
        }
    }
}
