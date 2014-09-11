using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public interface ISender
    {
        void sendMessage(string message);
    }
}
