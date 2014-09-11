using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Scooter : IVehicule
    {
        private string m_power;
        private string m_year;
        private Manufacter m_manufacter;

        internal Manufacter Manufacter
        {
            get { return m_manufacter; }
            set { m_manufacter = value; }
        }

        public string Year
        {
            get { return m_year; }
            set { m_year = value; }
        }

        public string Power
        {
            get { return m_power; }
            set { m_power = value; }
        }

        public IVehicule shallowCopy()
        {
            return (IVehicule)this.MemberwiseClone();
        }

        public IVehicule deepCopy()
        {
            Scooter scooter = (Scooter)this.MemberwiseClone();
            scooter.Manufacter = new Manufacter(m_manufacter.Company, m_manufacter.Country);
            return scooter;
        }
    }
}
