using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    public class ImageEnumerator: IImageIterator
    {
        private ImageAggregate m_aggregate;
        int m_position;

        public ImageEnumerator(ImageAggregate aggregate)
        {
            m_aggregate = aggregate;
        }

        public void Reset()
        {
            m_position = -1;
        }

        public void MoveFirst()
        {
            if (m_aggregate.Count == 0)
            {
                throw new InvalidOperationException();
            }
            m_position = 0;
        }

        public bool MoveNext()
        {
            m_position++;
            return m_position < m_aggregate.Count;
        }

        public ImageBase Current
        {
            get
            {
                if (m_position < m_aggregate.Count)
                {
                    return m_aggregate[m_position];
                }
                throw new InvalidOperationException();
            }
        }
    }
}
