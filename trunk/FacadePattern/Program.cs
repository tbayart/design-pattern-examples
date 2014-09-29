using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    /// <summary>
    /// To synthesis subclasses and subsystems
    /// To provide an interface to acess subsystems and subclasses
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            computer.Run();
            Console.ReadKey();
        }
    }
}
