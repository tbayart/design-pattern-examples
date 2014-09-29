using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class CPU
    {
        public CPU()
        {
        }

        public void Freeze()
        {
            Console.WriteLine("CPU is frozen.");
        }

        public void Excute()
        {
            Console.WriteLine("CPU has been excuted.");
        }

        public void Jump(long position)
        {
            Console.WriteLine("CPU jump into {0}", position);
        }
    }
}
