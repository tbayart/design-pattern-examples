using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public interface IVehicule
    {
        IVehicule shallowCopy();
        IVehicule deepCopy();
    }
}
