using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class ForwardCommand: RobotCommandBase
    {
        public int Distance { get; set; }
        public ForwardCommand(Robot robot) : base(robot) { }
        public override void Excute()
        {
            m_robot.Move(Distance);
        }
        public override void Undo()
        {
            m_robot.Move(-Distance);
        }
    }
}
