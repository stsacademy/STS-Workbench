using STSdb4.Data;
using STSdb4.Database;
using STSdb4.WaterfallTree;
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

            Index = (XIndex)Engine.OpenXIndex(KeyTypes, RecordTypes, TableName); //DataType.Array(...)?!
        }

        public void AddRow(object[] rowValues)
        {
            object[] keys = GetParameters(rowValues, true);
            object[] records = GetParameters(rowValues, false);

            DataToObjectsTransformer keyTransformer = new DataToObjectsTransformer(KeyTypes);
            DataToObjectsTransformer recordTransformer = new DataToObjectsTransformer(RecordTypes);

            IData key = keyTransformer.ToIData(keys);
            IData record = recordTransformer.ToIData(records);

            Index[key] = record;
            
            RowCount++;
        }

        public void RemoveRow(object[] rowValues) //long row
        {
            object[] keys = GetParameters(rowValues, true);
            object[] records = GetParameters(rowValues, false);

            DataToObjectsTransformer keyTransformer = new DataToObjectsTransformer(KeyTypes);
            IData key = keyTransformer.ToIData(keys);

            IData find = Index.Find(key);

            Index.Delete(find);
        }

        public void Clear()
        {
            Index.Clear();
        }

        #region private methods

        private object[] GetParameters(object[] rowValues, bool isKey)
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
                    if (!Columns[i].IsPrimaryKey)
                        indexes.Add(i);
                }
            }

            return BuildParameters(rowValues, indexes);
        }

        private object[] BuildParameters(object[] rowValues, List<int> indexes)
        {
            object[] temp = new object[indexes.Count];

            for (int i = 0; i < temp.Length; i++)
            {
                var t = rowValues[indexes[i]].GetType();
                temp[i] = rowValues[indexes[i]];
            }

            return temp;
        }

        private Type[] GetTypes(object[] dataTypes)
        {
            Type[] types = new Type[dataTypes.Length];

            for (int i = 0; i < types.Length; i++)
                types[i] = dataTypes[i].GetType();

            return types;
        }

        #endregion
    }
}
