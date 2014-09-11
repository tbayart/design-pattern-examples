using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    /// <summary>
    // Separate abstraction | implemention 
    // For extending functions of system
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender myEmailSender = new EmailSender();
            WebSender myWebSender = new WebSender();

            SystemMessage mySystemMessage = new SystemMessage();
            mySystemMessage.Message = "Hello word!";
            mySystemMessage.Isender = myEmailSender;
            mySystemMessage.sendMessage();

            mySystemMessage.Isender = myWebSender;
            mySystemMessage.sendMessage();

            Console.ReadKey();
        }
    }
}
