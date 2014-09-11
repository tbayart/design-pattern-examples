using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data.SQLite;
using System.Data;

namespace FactoryPattern
{
    class XMLConnection : DBConnection
    {
        private XmlDocument m_xmlDocument;

        public XMLConnection(string sourceFile)
            : base(sourceFile)
        {
            m_xmlDocument = new XmlDocument();
            m_xmlDocument.Load(sourceFile);
        }

        public override DataObject loadDataObject()
        {
            DataObject dtObj = new DataObject();
            XmlNode root = m_xmlDocument.DocumentElement;
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    // Set table name by node name
                    DataTable dtTable = new DataTable(root.ChildNodes[i].Name);
                    if (root.ChildNodes[i].HasChildNodes)
                    {
                        DataRow dtRow = dtTable.NewRow();
                        for (int j = 0; j < root.ChildNodes[i].ChildNodes.Count; j++)
                        {
                            // Add column and value
                            dtTable.Columns.Add(root.ChildNodes[i].ChildNodes[j].Name, typeof(string));
                            dtRow[j] = root.ChildNodes[i].ChildNodes[j].InnerText;
                        }
                        dtTable.Rows.Add(dtRow);
                    }
                    dtObj.DataSet.Tables.Add(dtTable);
                }
            }
            return dtObj;
        }

        public override void saveDataObject(DataObject dataObject)
        {
            XmlNode root = m_xmlDocument.DocumentElement;
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].HasChildNodes)
                    {
                        for (int j = 0; j < root.ChildNodes[i].ChildNodes.Count; j++)
                        {
                            root.ChildNodes[i].ChildNodes[j].InnerText =
                                dataObject.DataSet.Tables[i].Rows[0][root.ChildNodes[i].ChildNodes[j].Name].ToString();
                        }
                    }
                }
            }
            m_xmlDocument.Save(m_sourceFile);
        }
    }
}
