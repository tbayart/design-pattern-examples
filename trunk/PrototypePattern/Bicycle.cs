using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Bicycle : ICloneable
    {
        private string m_marque;
        private string m_price;
        private Manufacter m_manufacter;
        private readonly string m_id;

        public string Id
        {
            get { return m_id; }
        }


        internal Manufacter Manufacter
        {
            get { return m_manufacter; }
            set { m_manufacter = value; }
        }

        public string Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public string Marque
        {
            get { return m_marque; }
            set { m_marque = value; }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
