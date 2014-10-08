using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class TestMemento
    {
        public string Name { get; private set; }
        public bool Status { get; private set; }
        
        public TestMemento(string name, bool status)
        {
            Name = name;
            Status = status;
        }
    }
}
