using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public abstract class Aircraft
    {
        private int m_altitude;
        private string RegistrationNumber { get; set; }
        private readonly IAirTrafficControl m_act;

        public int Altitude
        {
            get { return m_altitude; }
            set
            {
                m_altitude = value;
                m_act.RegistrerAircraft(this);
            }
        }

        public Aircraft(string registrationNumber, IAirTrafficControl act)
        {
            RegistrationNumber = registrationNumber;
            m_act = act;
            m_act.RegistrerAircraft(this);
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }

        public void ReceiveWarning(Aircraft aircraft)
        {
            Console.WriteLine("ATC: {0} - {1} is at your flight altitude.", this.RegistrationNumber,
                aircraft.RegistrationNumber);
        }
    }
}
