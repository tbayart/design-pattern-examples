using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class DBConnection
    {
        protected string m_sourceFile;

        public DBConnection(string sourceFile)
        {
            m_sourceFile = sourceFile;
        }

        public virtual DataObject loadDataObject()
        {
            return new DataObject();
        }

        public virtual void saveDataObject(DataObject dataObject)
        {
        }
    }
}
