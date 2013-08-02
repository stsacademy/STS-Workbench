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

            Data<object[]> key = GetParameters(rowValues, true);
            Data<object[]> record = GetParameters(rowValues, false);

            Index[key] = record;

            RowCount++;
        }

        private Data<object[]> GetParameters(object[] rowValues, bool isKey)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < Columns.Length; i++)
            {
                if (isKey)
                {
                    if (Columns[i].IsPrimaryKey)
                    {
                        indexes.Add(i);
                    }
                }
                else
                {
                    if(!Columns[i].IsPrimaryKey)
                        indexes.Add(i); 
                }
            }

            return new Data<object[]>(BuildParameters(rowValues, indexes));
        }

        private object[] BuildParameters(object[] rowValues, List<int> indexes)
        {
            object[] temp = new object[indexes.Count];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rowValues[indexes[i]];
            }

            return temp;
        }
    }
}
