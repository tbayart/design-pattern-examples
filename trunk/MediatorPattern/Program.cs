using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    class Program
    {
        /// <summary>
        /// Mediator objects are used to encapsulate and centralize the interactions between classes.
        /// Ex: ATC is a mediator to send commands to aircrafts
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var regionalATC = new RegionalAirTrafficControl();
            var aircraft1 = new AirbusA380("A141", regionalATC);
            var aircraft2 = new Boeing747("B312", regionalATC);
            var aircraft3 = new Boeing747("B343", regionalATC);
            aircraft1.Altitude = 600;
            aircraft2.Altitude = 1100;
            aircraft3.Altitude = 3000;
            Console.WriteLine("--- ACT ---");
            regionalATC.SendWarningMessage(aircraft2); // appear warining msg
            Console.WriteLine("--- Aircraft ---");
            Console.WriteLine("Altitudes: Aircraft1 {0}, Aircraft1 {1}, Aircraft1 {2}",
                aircraft1.Altitude, aircraft2.Altitude, aircraft3.Altitude);
            Console.ReadKey();
        }
    }
}
