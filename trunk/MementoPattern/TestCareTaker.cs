using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class TestCareTaker
    {
        readonly Stack<TestMemento> m_testMemento = new Stack<TestMemento>();

        public TestMemento GetMemento()
        {
            return m_testMemento.Pop();
        }

        public void Add(TestMemento testMemento)
        {
            m_testMemento.Push(testMemento);
        }
    }
}
