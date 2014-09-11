using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee
    {
        public void requestA()
        {
            Console.WriteLine("Request A");
        }
    }
}
