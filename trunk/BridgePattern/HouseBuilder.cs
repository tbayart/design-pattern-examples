using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    abstract class HouseBuilder
    {
        protected House m_house;

        public HouseBuilder()
        {
            m_house = new House();
        }


        public void showInfo()
        {
            Console.WriteLine("First floor: {0}", m_house.FirstFloor);
            Console.WriteLine("Second floor: {0}", m_house.SecondFloor);
            Console.WriteLine("-------------");
        }

        public abstract void buildFirstFloor();
        public abstract void buildSecondFloor();
    }
}
