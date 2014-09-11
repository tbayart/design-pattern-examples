using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class VillaBuilder : HouseBuilder
    {
        public override void buildFirstFloor()
        {
            m_house.FirstFloor = "50 m2";
        }

        public override void buildSecondFloor()
        {
            m_house.SecondFloor = "60 m2";
        }
    }
}
