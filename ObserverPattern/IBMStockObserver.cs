using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public class IBMStockObserver : IStockObserverBase
    {
        public string Name { get; set;}

        public IBMStockObserver(string name)
        {
            Name = name;
        }

        public void Notify(Stock stock)
        {
            if (stock.Code == "IBM")
            {
                // Print value changed
                Console.WriteLine("Notified {0} of {1}'s " +
                          "change to {2:C}", Name, stock.Code, stock.Price);
            }
        }
    }
}
