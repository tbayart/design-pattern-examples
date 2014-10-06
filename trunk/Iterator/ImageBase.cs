using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public class ImageBase
    {
        public System.Drawing.Bitmap Image { get; set; }
        public string Name { get; set; }

        public bool StartTest()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 10);
            return value > 5;
        }
    }
}
