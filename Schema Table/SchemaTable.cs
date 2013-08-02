using STSdb4.Data;
using STSdb4.Database;
using STSdb4.WaterfallTree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Schema_Table
{
    public class SchemaTable
    {
        public string DatabaseName;
        public bool Compress;
        public string DatabasePath;

        private Dictionary<string, Column[]> Table;
        private StorageEngine Engine;

        private string SystemFile;
        private string DataFile;

        public SchemaTable(string databaseName, bool compress, string databasePath)
        {
            DatabaseName = databaseName;
            Compress = compress;
            DatabasePath = databasePath;

            Directory.CreateDirectory(DatabasePath);

            Table = new Dictionary<string, Column[]>();

            SystemFile = Path.Combine(DatabasePath, "STSdb4System.sys");
            DataFile = Path.Combine(DatabasePath, DatabaseName + ".data");

            Engine = (StorageEngine)STSdb4.Database.STSdb.FromFile(SystemFile, DataFile, Compress);
        }

        public void CreateTable(string tableName, Column[] columns)
        {
            bool contains = Table.ContainsKey(tableName);

            if (contains)
                throw new Exception("Table already exsist.");

            Table.Add(tableName, columns);
        }

        public void AddEntry(string tableName, object[] parameters)
        {
            DataType[] keyTypes = GetKeyTypes(tableName);
            DataType[] recordTypes = GetRecordTypes(tableName);

            XIndex index = (XIndex)Engine.OpenXIndex(keyTypes, recordTypes, tableName);
            
            Data<int, long> d = new Data<int, long>(2, 4);
            Data<string, string, string> s = new Data<string, string, string>("a", "b", "c");

            index.Replace(d, s);
            var f = index.Find(d);
        }

        public DataType[] GetKeyTypes(string tableName)
        {
            Column[] columns = GetColumns(tableName);

            List<DataType> list = new List<DataType>();

            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i].IsPrimaryKey)
                    list.Add(columns[i].ColumnType);
            }

            return list.ToArray();
        }

        public DataType[] GetRecordTypes(string tableName)
        {
            Column[] columns = GetColumns(tableName);

            List<DataType> list = new List<DataType>();

            for (int i = 0; i < columns.Length; i++)
            {
                if (!columns[i].IsPrimaryKey)
                    list.Add(columns[i].ColumnType);
            }

            return list.ToArray();
        }

        private Column[] GetColumns(string tableName)
        {
            Column[] columns;

            bool contains = Table.TryGetValue(tableName, out columns);

            if (!contains)
                throw new Exception("Cannot find Table.");

            return columns;
        }
    }
}
