using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class Boeing747: Aircraft
    {
        public Boeing747(string registrationNumber, IAirTrafficControl act)
            : base(registrationNumber, act)
        {
        }
    }
}
