﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// When one object's state changes, all dependent objects are updated automatically.
    /// Change att of all obj
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var stockTicker = new ConcreteStockTicker();
            var ibmObserver = new IBMStockObserver("ROBER KANASZ");
            var ibmObserver2 = new IBMStockObserver("ROBER KANASZ");
            var allObserver = new AllStockObserver("IVOR LOTOCASH");

            stockTicker.Register(ibmObserver);
            stockTicker.Register(ibmObserver2);
            stockTicker.Register(allObserver);

            foreach (var s in StockData.getNext())
                stockTicker.Stock = s; // here, object changed is Stock -> change all att of obj
            Console.ReadKey();
        }

        public static class StockData
        {
            private static decimal[] samplePrices =
               new decimal[] { 10.00m, 10.25m, 555.55m, 9.50m, 9.03m, 500.00m, 499.99m, 10.10m, 10.01m };
            private static string[] sampleStocks = new string[] { "MSFT", "MSFT", 
                "GOOG", "MSFT", "MSFT", "GOOG", 
                "GOOG", "MSFT", "IBM" };
            public static IEnumerable<Stock> getNext()
            {
                for (int i = 0; i < samplePrices.Length; i++)
                {
                    Stock s = new Stock();
                    s.Code = sampleStocks[i];
                    s.Price = samplePrices[i];
                    yield return s; // yield -> return a collection IEnumerable
                }
            }
        }
    }
}
