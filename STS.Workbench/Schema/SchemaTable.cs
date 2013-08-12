using STSdb4.Data;
using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Schema
{
    class SchemaTable
    {
        public string DatabaseName;
        public bool Compress;
        public string DatabasePath;

        private Dictionary<string, DataTable> Table;
        private StorageEngine Engine;

        private string SystemFile;
        private string DataFile;

        public SchemaTable(string databaseName, bool compress, string databasePath)
        {
            DatabaseName = databaseName;
            Compress = compress;
            DatabasePath = databasePath;

            Directory.CreateDirectory(DatabasePath);

            Table = new Dictionary<string, DataTable>();

            SystemFile = Path.Combine(DatabasePath, "System.sys");
            DataFile = Path.Combine(DatabasePath, DatabaseName + ".data");

            Engine = (StorageEngine)STSdb4.Database.STSdb.FromFile(SystemFile, DataFile, Compress);
        }

        public DataTable CreateTable(string tableName, Column[] columns)
        {
            bool contains = Table.ContainsKey(tableName);

            if (contains)
                throw new Exception("Table already exsist.");

            DataTable table = new DataTable(this, Engine, tableName, columns);

            Table.Add(tableName, table);

            return table;
        }

        public void RemoveTable(string tableName)
        {
            bool removed = Table.Remove(tableName);

            if (!removed)
                throw new Exception("Table does not exsist.");
        }
    }
}
