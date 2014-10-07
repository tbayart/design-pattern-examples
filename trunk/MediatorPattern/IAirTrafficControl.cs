﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public interface IAirTrafficControl
    {
        void RegistrerAircraft(Aircraft aircraft);
        void SendWarningMessage(Aircraft aircraft);
    }
}
