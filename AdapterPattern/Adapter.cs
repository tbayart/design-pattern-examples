using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Adapter : Adaptee, ITarget
    {
        public void requestB()
        {
            requestA();
        }
    }
}
