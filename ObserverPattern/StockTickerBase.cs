using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public abstract class StockTickerBase
    {
        readonly protected List<IStockObserverBase> m_observers = new List<IStockObserverBase>();

        public void Register(IStockObserverBase observer)
        {
            if (!m_observers.Contains(observer))
            {
                m_observers.Add(observer);
            }
        }

        public void Unregister(IStockObserverBase observer)
        {
            if (!m_observers.Contains(observer))
            {
                m_observers.Remove(observer);
            }
        }

        public abstract void Notify();
    }
}
