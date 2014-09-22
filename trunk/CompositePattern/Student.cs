using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Student : IPeople
    {
        public string Name { get; set; }

        public void Render(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
