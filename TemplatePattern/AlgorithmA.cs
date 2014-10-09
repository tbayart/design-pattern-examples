using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    public class AlgorithmA: AlgoithmBase
    {
        public override void Step1()
        {
            Console.WriteLine("Algo A -> Step1");
        }

        public override void Step2()
        {
            Console.WriteLine("Algo A -> Step2");
        }
    }
}
