using STSdb4.Data;
using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Schema
{
    class DataTable
    {
        public string TableName;
        public Column[] Columns;

        private SchemaTable SchemaTable;

        private StorageEngine Engine;
        private IIndex Index;

        private DataType[] KeyTypes;
        private DataType[] RecordTypes;

        public DataTable(SchemaTable schemaTable, StorageEngine engine, string tableName, Column[] columns)
        {
            SchemaTable = schemaTable;
            Engine = engine;

            TableName = tableName;
            Columns = columns;

            KeyTypes = SchemaTable.GetKeyTypes(TableName);
            RecordTypes = SchemaTable.GetRecordTypes(TableName);

            Index = Engine.OpenXIndex(KeyTypes, RecordTypes, TableName);
        }

        public void AddRecords()
        {
            //test comment
        }
    }
}
