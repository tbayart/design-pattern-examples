using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FactoryPattern
{
    /// <summary>
    /// For many db differents
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FactoryConnection factoryConnection = new FactoryConnection();
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            XMLConnection xmlConnection =
            factoryConnection.openXMLConnection("../../Database.xml");
            DataObject xmlObj = xmlConnection.loadDataObject();

            xmlObj.DataSet.Tables[2].Rows[0]["pattern_binary_level"] = 1127;
            xmlConnection.saveDataObject(xmlObj);
            sw.Stop();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("--------     XML   ------------");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < xmlObj.DataSet.Tables.Count; i++)
            {
                Console.WriteLine(xmlObj.DataSet.Tables[i].TableName);
                foreach (DataRow row in xmlObj.DataSet.Tables[i].Rows)
                {
                    foreach (DataColumn col in xmlObj.DataSet.Tables[i].Columns)
                    {
                        Console.WriteLine(col.ColumnName + " : " + row[col.ColumnName]);
                    }
                }
                Console.WriteLine("-------------------------------");
            }

            System.Diagnostics.Stopwatch sw2 = System.Diagnostics.Stopwatch.StartNew();
            SqliteConnection sqliteConnection =
                factoryConnection.openSqliteConnection("../../test.db");
            DataObject sqliteObj = sqliteConnection.loadDataObject();

            sqliteObj.DataSet.Tables[0].Rows[0]["seq"] = 111;
            sqliteConnection.saveDataObject(sqliteObj);
            sw2.Stop();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------     SQLite   -----------");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < sqliteObj.DataSet.Tables.Count; i++)
            {
                Console.WriteLine(sqliteObj.DataSet.Tables[i].TableName);
                foreach (DataRow row in sqliteObj.DataSet.Tables[i].Rows)
                {
                    foreach (DataColumn col in sqliteObj.DataSet.Tables[i].Columns)
                    {
                        Console.WriteLine(col.ColumnName + " : " + row[col.ColumnName]);
                    }
                }
                Console.WriteLine("-------------------------------");
            }


            Console.WriteLine("Time XML: {0} ms", sw.ElapsedMilliseconds);
            Console.WriteLine("Time SQLite: {0} ms", sw2.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
