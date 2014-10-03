using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class RobotController
    {
        public Queue<RobotCommandBase> Commmands;
        private Stack<RobotCommandBase> m_undoStack;

        public RobotController()
        {
            Commmands = new Queue<RobotCommandBase>();
            m_undoStack = new Stack<RobotCommandBase>();
        }

        public void ExcuteCommands()
        {
            Console.WriteLine("Excute commands.");
            while (Commmands.Count > 0)
            {
                RobotCommandBase command = Commmands.Dequeue();
                command.Excute();
                m_undoStack.Push(command);
            }
        }

        public void UndoCommands(int nbUndos)
        {
            Console.WriteLine("Undo commands.");
            while (nbUndos > 0 && m_undoStack.Count > 0)
            {
                RobotCommandBase command = m_undoStack.Pop();
                command.Undo();
                nbUndos--;
            }
        }
    }
}
