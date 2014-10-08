using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// Save current state of object without breaking the rules of encapsulation
    /// Ex: save test history
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var testCareTaker = new TestCareTaker();
            var imageTest = new ImageTest { Name = "Image1.bmp", Status = true};
            testCareTaker.Add(imageTest.CreateMemento());
            imageTest = new ImageTest { Name = "Image2.bmp", Status = false };
            testCareTaker.Add(imageTest.CreateMemento());
            imageTest = new ImageTest { Name = "Image3.bmp", Status = true };
            imageTest.ShowInfo();

            imageTest.Undo(testCareTaker.GetMemento());
            imageTest.ShowInfo();
            imageTest.Undo(testCareTaker.GetMemento());
            imageTest.ShowInfo();
            Console.ReadKey();
        }
    }
}
