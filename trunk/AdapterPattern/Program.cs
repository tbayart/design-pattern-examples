using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client(new Adapter());
            myClient.request();

            Console.ReadKey();
        }
    }
}
