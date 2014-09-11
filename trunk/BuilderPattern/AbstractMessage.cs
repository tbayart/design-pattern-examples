using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    abstract class AbstractMessage
    {
        private string m_message;
        private ISender m_isender;

        public string Message
        {
            get { return m_message; }
            set { m_message = value; }
        }

        internal ISender Isender
        {
            get { return m_isender; }
            set { m_isender = value; }
        }

        public abstract void sendMessage();
    }
}
