using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    class Memory
    {
        public Memory()
        {
        }

        public void Load(byte[] bytes)
        {
            Console.WriteLine("Start loading.");
            foreach (var b in bytes)
            {
                Console.WriteLine(b + " ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Loading completed.");
        }
    }
}
