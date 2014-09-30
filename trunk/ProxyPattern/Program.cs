using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// - Don’t want to access to the resource or subject directly 
    /// - Don’t want to expose all of the methods of subject class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var serieAPlayer = new ProxySerieAPlayer();
            serieAPlayer.Shoot();

            Console.ReadKey();
        }
    }
}
