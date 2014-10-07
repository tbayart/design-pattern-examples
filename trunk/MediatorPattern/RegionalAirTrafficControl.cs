using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class RegionalAirTrafficControl: IAirTrafficControl
    {
        readonly List<Aircraft> m_registeredAircrafts = new List<Aircraft>();

        public void RegistrerAircraft(Aircraft aircraft)
        {
            if (!m_registeredAircrafts.Contains(aircraft))
            {
                m_registeredAircrafts.Add(aircraft);
            }
        }

        public void SendWarningMessage(Aircraft aircraft)
        {
            int minHeightDistance = 1000;
            var list = from a in m_registeredAircrafts
                       where a != aircraft && Math.Abs(a.Altitude - aircraft.Altitude) < minHeightDistance
                       select a;
            foreach (var a in list)
            {
                a.ReceiveWarning(aircraft);
                if (a.Altitude > aircraft.Altitude)
                {
                    a.Climb(minHeightDistance);
                }
                else
                {
                    aircraft.Climb(minHeightDistance);
                }
            }
        }
    }
}
