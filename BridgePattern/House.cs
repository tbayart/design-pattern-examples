using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public class House
    {
        private string m_firstFloor;
        private string m_secondFloor;

        public string SecondFloor
        {
            get { return m_secondFloor; }
            set { m_secondFloor = value; }
        }

        public string FirstFloor
        {
            get { return m_firstFloor; }
            set { m_firstFloor = value; }
        }

        public int add(int a, int b)
        {
            return a + b;
        }

    }
}
