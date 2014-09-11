using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// Unique instance of class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            printName();
            printAddress();
            Console.ReadKey();
        }

        public static void printName()
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton1 == singleton2);

            singleton1.Fields["haha"] = "aa";
            Console.WriteLine(Singleton.GetInstance().Fields["haha"]);
            singleton1.Fields["haha"] = "oo";
            Console.WriteLine(Singleton.GetInstance().Fields["haha"]);
            Console.WriteLine(singleton1.Fields["haha"]);
        }

        public static void printAddress()
        {
            Console.WriteLine("-----------------------");
            var singleton3 = Singleton.GetInstance();
            Console.WriteLine(Singleton.GetInstance().Fields["haha"]);
            Console.WriteLine(singleton3.Fields["haha"]);
        }
    }
}
