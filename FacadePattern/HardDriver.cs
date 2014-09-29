using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class HardDriver
    {
        public HardDriver()
        {
        }

        public void CleanUp()
        {
            Console.WriteLine("HardDriver has been cleaned up.");
        }

        public byte[] Read(int size)
        {
            var bytes = new byte[size];
            var random = new Random();
            random.NextBytes(bytes);
            return bytes;
        }
    }
}
