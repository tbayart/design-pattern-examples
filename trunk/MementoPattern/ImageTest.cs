using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class ImageTest
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public TestMemento CreateMemento()
        {
            return new TestMemento(Name, Status);
        }

        public void Undo(TestMemento testMemento)
        {
            Name = testMemento.Name;
            Status = testMemento.Status;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Image Name: {0}, Status: {1}", Name, Status);
        }
    }
}
