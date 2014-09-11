using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    class Manufacter
    {
        private string m_company;
        private string m_country;

        public Manufacter(string company, string country)
        {
            m_company = company;
            m_country = country;
        }

        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }

        public string Company
        {
            get { return m_company; }
            set { m_company = value; }
        }
    }
}
