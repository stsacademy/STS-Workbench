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
        public long RowCount { get; private set; }

        private SchemaTable SchemaTable;

        private StorageEngine Engine;
        private XIndex Index;

        private DataType[] KeyTypes;
        private DataType[] RecordTypes;

        public DataTable(SchemaTable schemaTable, StorageEngine engine, string tableName, Column[] columns)
        {
            SchemaTable = schemaTable;
            Engine = engine;
            RowCount = 0;

            TableName = tableName;
            Columns = columns;

            KeyTypes = SchemaTable.GetKeyTypes(TableName);
            RecordTypes = SchemaTable.GetRecordTypes(TableName);

            Index = (XIndex)Engine.OpenXIndex(KeyTypes, RecordTypes, TableName);
        }

        public void AddRow(object[] rowValues)
        {
            //test comment

            var keys = GetKeys(rowValues);
            var records = GetRecords(rowValues);

            Data<object[]> key = new Data<object[]>(GetKeys(rowValues));
            Data<object[]> record = new Data<object[]>(GetRecords(rowValues));

            Index.Replace(key, record);

            RowCount++;
        }

        private object[] GetKeys(object[] rowValues)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < Columns.Length; i++)
            {
                if (Columns[i].IsPrimaryKey)
                    list.Add(i);
            }

            object[] keys = new object[list.Count];

            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = rowValues[list[i]];
            }

            return keys;
        }

        private object[] GetRecords(object[] rowValues)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < Columns.Length; i++)
            {
                if (!Columns[i].IsPrimaryKey)
                    list.Add(i);
            }

            object[] records = new object[list.Count];

            for (int i = 0; i < records.Length; i++)
            {
                records[i] = rowValues[list[i]];
            }

            return records;
        }
    }
}
