using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace FactoryPattern
{
    class SqliteConnection : DBConnection
    {
        private SQLiteConnection m_connection;

        public SQLiteConnection Connection
        {
            get { return m_connection; }
            set { m_connection = value; }
        }

        public SqliteConnection(string sourceFile)
            : base(sourceFile)
        {
            m_connection = new SQLiteConnection(@"data source=" + sourceFile);
        }

        public override DataObject loadDataObject()
        {
            DataObject dtObj = new DataObject();
            // Get list of table name 
            SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type = 'table'", m_connection);
            SQLiteDataAdapter dtAdapter = new SQLiteDataAdapter(cmd);
            DataTable listTable = new DataTable();
            dtAdapter.Fill(listTable);
            // Add table to dataset
            foreach (DataRow row in listTable.Rows)
            {
                cmd = new SQLiteCommand("SELECT * FROM " + row[listTable.Columns[0]], m_connection);
                dtAdapter = new SQLiteDataAdapter(cmd);
                DataTable dtTable = new DataTable(row[listTable.Columns[0]].ToString());
                dtAdapter.Fill(dtTable);
                dtObj.DataSet.Tables.Add(dtTable);
            }
            //m_connection.Close();
            return dtObj;
        }

        public override void saveDataObject(DataObject dataObject)
        {
            SQLiteTransaction transaction = m_connection.BeginTransaction();
            for (int i = 0; i < dataObject.DataSet.Tables.Count; i++)
            {
                truncateTable(dataObject.DataSet.Tables[i].TableName);
                var dic = new Dictionary<string, object>();
                for (int j = 0; j < dataObject.DataSet.Tables[i].Rows.Count; j++)
                {
                    for (int k = 0; k < dataObject.DataSet.Tables[i].Columns.Count; k++)
                    {
                        dic[dataObject.DataSet.Tables[i].Columns[k].ColumnName] =
                            dataObject.DataSet.Tables[i].Rows[j][dataObject.DataSet.Tables[i].Columns[k].ColumnName];
                    }
                }
                insert(dataObject.DataSet.Tables[i].TableName, dic);
            }
            transaction.Commit();
        }

        public void truncateTable(string tableName)
        {
            SQLiteCommand cmd = m_connection.CreateCommand();
            cmd.CommandText = "DELETE FROM " + tableName;
            cmd.ExecuteNonQuery();
        }

        public void insert(string tableName, Dictionary<string, object> dic)
        {
            SQLiteCommand cmd = m_connection.CreateCommand();
            StringBuilder sbCol = new System.Text.StringBuilder();
            StringBuilder sbVal = new System.Text.StringBuilder();

            foreach (KeyValuePair<string, object> kv in dic)
            {
                if (sbCol.Length == 0)
                {
                    sbCol.Append("insert into ");
                    sbCol.Append(tableName);
                    sbCol.Append("(");
                }
                else
                {
                    sbCol.Append(",");
                }

                sbCol.Append("`");
                sbCol.Append(kv.Key);
                sbCol.Append("`");

                if (sbVal.Length == 0)
                {
                    sbVal.Append(" values(");
                }
                else
                {
                    sbVal.Append(", ");
                }

                sbVal.Append("@v");
                sbVal.Append(kv.Key);
            }

            sbCol.Append(") ");
            sbVal.Append(");");

            cmd.CommandText = sbCol.ToString() + sbVal.ToString();

            foreach (KeyValuePair<string, object> kv in dic)
            {
                cmd.Parameters.AddWithValue("@v" + kv.Key, kv.Value);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
