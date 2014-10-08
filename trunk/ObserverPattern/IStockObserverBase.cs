﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface IStockObserverBase
    {
        void Notify(Stock stock);
    }
}
