using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// - Queued commands
    /// - Rollback capabilities
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            var robotController = new RobotController();
            var command = new ForwardCommand(robot);
            command.Distance = 10;
            robotController.Commmands.Enqueue(command);
            command = new ForwardCommand(robot);
            command.Distance = 15;
            robotController.Commmands.Enqueue(command);
            command = new ForwardCommand(robot);
            command.Distance = -20;
            robotController.Commmands.Enqueue(command);

            robotController.ExcuteCommands();
            robotController.UndoCommands(2);
            Console.ReadKey();
        }
    }
}
