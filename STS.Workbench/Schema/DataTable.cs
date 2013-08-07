﻿using STSdb4.Data;
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
        public Row[] Rows;
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
            Rows = new Row[4];

            KeyTypes = SchemaTable.GetKeyTypes(TableName);
            RecordTypes = SchemaTable.GetRecordTypes(TableName);

            Index = (XIndex)Engine.OpenXIndex(KeyTypes, RecordTypes, TableName);
        }

        public void AddRow(Row row)
        {
            EnsureCapacity();
            Rows[row.RowNumber - 1] = row;

            object[] keys = GetParameters(row.RowValues, true);
            object[] records = GetParameters(row.RowValues, false);

            DataToObjectsTransformer keyTransformer = new DataToObjectsTransformer(KeyTypes);
            DataToObjectsTransformer recordTransformer = new DataToObjectsTransformer(RecordTypes);

            IData key = keyTransformer.ToIData(keys);
            IData record = recordTransformer.ToIData(records);

            Index[key] = record;

            RowCount++;
        }

        public void RemoveRow(Row row)
        {
            if (Rows[row.RowNumber - 1] == null)
                return;

            Rows[row.RowNumber - 1] = null;

            object[] keys = GetParameters(row.RowValues, true);
            object[] records = GetParameters(row.RowValues, false);

            DataToObjectsTransformer keyTransformer = new DataToObjectsTransformer(KeyTypes);
            IData key = keyTransformer.ToIData(keys);

            IData find = Index.Find(key);

            Index.Delete(find);

            RowCount--;
        }

        public void RemoveRow(Row firstRow, Row secondRow)
        {
            if (firstRow.RowNumber > secondRow.RowNumber)
                throw new Exception("First Row is Greater Than Second Row.");

            if (firstRow.RowNumber == secondRow.RowNumber)
            {
                RemoveRow(firstRow);

                return;
            }

            long index = firstRow.RowNumber - 1;

            for (int i = 0; i < (secondRow.RowNumber - firstRow.RowNumber) + 1; i++)
            {
                Rows[index] = null;

                index++;
                RowCount--;
            }

            DataToObjectsTransformer keyTrasformer = new DataToObjectsTransformer(KeyTypes);

            IData firstKey = keyTrasformer.ToIData(firstRow.RowValues);
            IData secondKey = keyTrasformer.ToIData(secondRow.RowValues);

            Index.Delete(firstKey, secondKey);
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
            if (rowValues == null)
                throw new ArgumentNullException("Row Values cannot be null.");

            if (rowValues.Length == 0)
                throw new Exception("Row Values Length cannot be zero.");

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

        private void EnsureCapacity()
        {
            if (RowCount == Rows.Length)
            {
                Row[] temp = Rows;

                Rows = new Row[temp.Length * 2];

                temp.CopyTo(Rows, 0);
            }
        }

        #endregion
    }
}
