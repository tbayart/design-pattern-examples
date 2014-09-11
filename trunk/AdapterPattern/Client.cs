using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    class Client
    {
        private ITarget m_iTarget;

        public ITarget ITarget
        {
            get { return m_iTarget; }
            set { m_iTarget = value; }
        }

        public Client(ITarget iTarget)
        {
            m_iTarget = iTarget;
        }

        public void request()
        {
            m_iTarget.requestB();
        }
    }
}
