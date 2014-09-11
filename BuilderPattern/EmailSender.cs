using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class EmailSender : ISender
    {
        public void sendMessage(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
