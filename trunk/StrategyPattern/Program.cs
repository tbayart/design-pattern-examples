using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
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
