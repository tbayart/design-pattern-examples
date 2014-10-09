using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplatePattern
{
    class Program
    {
        /// <summary>
        /// The template method pattern is a design pattern that allows a group of interchangeable, 
        /// similarly structured, multi-step algorithms to be defined. 
        /// Each algorithm follows the same series of actions but provides a different implementation 
        /// of the steps.
        /// ~ Strategy Pattern
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AlgoithmBase algoA = new AlgorithmA();
            algoA.TemplateMethod();
            AlgoithmBase algoB = new AlgorithmB();
            algoB.TemplateMethod();
            Console.ReadKey();
        }
    }
}
