using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IteratorPattern
{
    /// <summary>
    /// Provide a way to access the elements of an aggregate object sequentially without 
    /// exposing its underlying representation. 
    /// Ex: test list of image ???
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ImageAggregate aggregate = new ImageAggregate();
            aggregate.Add(new ImageBase() {Name = "cam", Image = new Bitmap(Image.FromFile("../../cam.bmp")) });
            aggregate.Add(new ImageBase() { Name = "Jet", Image = new Bitmap(Image.FromFile("../../Jet.jpg")) });
            aggregate.Add(new ImageBase() { Name = "Jet2", Image = new Bitmap(Image.FromFile("../../Jet.jpg")) });
            aggregate.Add(new ImageBase() { Name = "Jet3", Image = new Bitmap(Image.FromFile("../../Jet.jpg")) });
            aggregate.Add(new ImageBase() { Name = "Jet4", Image = new Bitmap(Image.FromFile("../../Jet.jpg")) });

            IImageIterator iterator = aggregate.GetIterator();
            iterator.Reset();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current.Name);
                if (iterator.Current.StartTest())
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("NG");
                }
                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
