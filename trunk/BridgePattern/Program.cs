using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// JOB13108: Pitch left, right, top, bot
    /// Diffenrent representations
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CastleBuilder myCastle = new CastleBuilder();
            myCastle.buildFirstFloor();
            myCastle.buildSecondFloor();
            myCastle.showInfo();

            VillaBuilder myVilla = new VillaBuilder();
            myVilla.buildFirstFloor();
            myVilla.buildSecondFloor();
            myVilla.showInfo();

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
