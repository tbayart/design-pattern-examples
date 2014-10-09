using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class TestStain: TestBase
    {
        private int m_randomNumber;
        public TestStain()
        {
            Random rnd = new Random();
            m_randomNumber = rnd.Next();
            System.Threading.Thread.Sleep(100);
        }

        public override bool isGood()
        {
            return m_randomNumber > 5;
        }

        public override bool isNG()
        {
            return !isGood();
        }
    }
}
