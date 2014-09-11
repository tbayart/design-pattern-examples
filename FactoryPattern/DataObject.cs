using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace FactoryPattern
{
    class DataObject
    {
        private DataSet m_dataSet;

        public DataSet DataSet
        {
            get { return m_dataSet; }
            set { m_dataSet = value; }
        }

        public DataObject()
        {
            m_dataSet = new DataSet();
        }

    }
}
