using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data.SQLite;

namespace FactoryPattern
{
    class FactoryConnection
    {
        public SqliteConnection openSqliteConnection(string sourceFile)
        {
            SqliteConnection sqliteConnection = new SqliteConnection(sourceFile);
            sqliteConnection.Connection.Open();
            return sqliteConnection;
        }

        public XMLConnection openXMLConnection(string sourceFile)
        {
            XMLConnection xmlConnection = new XMLConnection(sourceFile);
            return xmlConnection;
        }
    }
}
