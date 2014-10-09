using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    class Program
    {
        /// <summary>
        /// The visitor pattern is a design pattern that separates 
        /// a set of structured data from the functionality that may be performed upon it. 
        /// The result of this separation is a data model with limited functionality and 
        /// a set of visitors that perform operations upon the data. 
        /// Another benefit is the ability to add a new visitor without modifying the existing structure. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var visitor = new CarElementVisitor();
            var car = new Car();
            car.Accept(visitor);
            Console.ReadKey();
        }
    }
}
