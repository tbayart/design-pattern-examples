using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    class CastleBuilder : HouseBuilder
    {
        public override void buildFirstFloor()
        {
            m_house.FirstFloor = "100 m2";
        }

        public override void buildSecondFloor()
        {
            m_house.SecondFloor = "200 m2";
        }
    }
}
