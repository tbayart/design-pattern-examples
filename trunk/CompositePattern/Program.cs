using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// - Data is organized in a tree structure.
    /// - Obj and group obj should be treated in the same way. (same function)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Supervisor Stephan = new Supervisor {Name = "Sheva"};
            Student Gildas = new Student {Name = "Kaka" };
            Student Johnathan = new Student {Name = "Nesta" };

            Stephan.addStudent(Gildas);
            Stephan.addStudent(Johnathan);

            Stephan.Render(1);
            Console.ReadKey();
        }
    }
}
