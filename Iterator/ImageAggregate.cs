using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public class ImageAggregate: IImageEnumerable
    {
        private List<ImageBase> m_images = new List<ImageBase>();

        public ImageBase this[int index]
        {
            get { return m_images[index]; }
        }

        public IImageIterator GetIterator()
        {
            return new ImageEnumerator(this);
        }

        public int Count
        {
            get { return m_images.Count;}
        }

        public void Add(ImageBase image)
        {
            m_images.Add(image);
        }
    }
}
