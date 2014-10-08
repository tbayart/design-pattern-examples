using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public class ConcreteStockTicker: StockTickerBase
    {
        private Stock m_stock;

        public Stock Stock
        {
            get { return m_stock; }
            set 
            { 
                m_stock = value;
                Notify();
            }
        }

        public override void Notify()
        {
            foreach (var observer in m_observers)
            {
                observer.Notify(m_stock);
            }
        }
    }
}
