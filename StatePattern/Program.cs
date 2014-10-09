using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// The state pattern is a design pattern that allows an object to completely
    /// change its behavior depending upon its current internal state.
    /// Ex: Play/Pause button
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var testButton = new ButtonBase();
            Console.WriteLine("--------------");
            testButton.PressPlayButton();
            testButton.PressPlayButton();
            testButton.PressPlayButton();
            testButton.PressPauseButton();
            testButton.PressPlayButton();
            Console.ReadKey();
        }
    }
}
