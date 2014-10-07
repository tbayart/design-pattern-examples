using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class AirbusA380: Aircraft
    {
        public AirbusA380(string registrationNumber, IAirTrafficControl act)
            : base(registrationNumber, act)
        {
        }
    }
}
