using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public abstract class RobotCommandBase: Robot
    {
        protected Robot m_robot;
        public RobotCommandBase(Robot robot)
        {
            m_robot = robot;
        }
        public abstract void Excute();
        public abstract void Undo();
    }
}
