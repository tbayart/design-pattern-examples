using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class Robot
    {
        public void Move(int distance)
        {
            if (distance > 0)
            {
                Console.WriteLine("Robot moves forward {0}", distance);
            }
            else
            {
                Console.WriteLine("Robot moves backward {0}", distance);
            }
        }
    }
}
