using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// Pool of objects
    /// </summary>
    public class UnitFactory
    {
        private readonly Dictionary<string, Unit> m_unit = new Dictionary<string, Unit>();
        public Unit GetUnit(string type)
        {
            // Don't new object if exists
            if (m_unit.ContainsKey(type))
            {
                return m_unit[type];
            }
            Unit unit;
            // 4 tpye of objects
            switch (type)
            {
                case "Axeman":
                    unit = new Infantry { Name = "Axeman", Attack = 3, Defend = 0, Range = 0, Speed = 5 };
                    break;
                case "Slinger":
                    unit = new Infantry { Name = "Slinger", Attack = 2, Defend = 0, Range = 4, Speed = 5 }; 
                    break;
                case "Cavalry" :
                    unit = new Stable { Name = "Cavalry", Attack = 8, Defend = 0, Range = 0, Speed = 8 }; 
                    break;
                case "Chariot":
                    unit = new Stable { Name = "Slinger", Attack = 7, Defend = 0, Range = 0, Speed = 8 }; 
                    break;
                default:
                    throw new ArgumentException();
            }
            m_unit.Add(type, unit);
            return unit;
        }
    }
}
