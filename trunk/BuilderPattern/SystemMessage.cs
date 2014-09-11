using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class SystemMessage : AbstractMessage
    {
        public override void sendMessage()
        {
            Isender.sendMessage(Message);
        }
    }
}
