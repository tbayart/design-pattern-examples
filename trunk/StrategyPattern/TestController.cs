using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class TestController
    {
        public TestBase TestBase { get; set; }
        
        public bool isGood()
        {
            bool isGoodResult = true;
            TestBase = new TestShape();
            isGoodResult &= TestBase.isGood();
            TestBase = new TestStain();
            isGoodResult &= TestBase.isGood();
            return isGoodResult;
        }
    }
}
