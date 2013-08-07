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
        public Row[] Rows;
        public long RowCount { get; private set; }

        private SchemaTable SchemaTable;

        private DataType[] KeyTypes;
        private DataType[] RecordTypes;

        private StorageEngine Engine;
        private XIndex Index;

        private DataToObjectsTransformer KeyTrasformer;
        private DataToObjectsTransformer RecordTransformer;

        public DataTable(SchemaTable schemaTable, StorageEngine engine, string tableName, Column[] columns)
        {
            SchemaTable = schemaTable;
            Engine = engine;

            TableName = tableName;
            Columns = columns;
            Rows = new Row[4];

            KeyTypes = SchemaTable.GetKeyTypes(TableName);
            RecordTypes = SchemaTable.GetRecordTypes(TableName);

            KeyTrasformer = new DataToObjectsTransformer(KeyTypes);
            RecordTransformer = new DataToObjectsTransformer(RecordTypes);

            Index = (XIndex)Engine.OpenXIndex(KeyTypes, RecordTypes, TableName);
        }

        public void AddRow(Row row)
        {
            EnsureCapacity();
            Rows[row.RowNumber - 1] = row;

            object[] keys = GetParameters(row.RowValues, true);
            object[] records = GetParameters(row.RowValues, false);

            IData key = KeyTrasformer.ToIData(keys);
            IData record = RecordTransformer.ToIData(records);

            Index[key] = record;

            RowCount = Index.Count();
        }

        public void InsertOrIgnoreRow(Row row)
        {
            EnsureCapacity();
            Rows[row.RowNumber - 1] = row;

            object[] keys = GetParameters(row.RowValues, true);
            object[] records = GetParameters(row.RowValues, false);

            IData key = KeyTrasformer.ToIData(keys);
            IData record = KeyTrasformer.ToIData(records);

            Index.InsertOrIgnore(key, record);

            RowCount = Index.Count();
        }

        public void RemoveRow(Row row)
        {
            if (Rows[row.RowNumber - 1] == null)
                return;

            Rows[row.RowNumber - 1] = null;

            object[] keys = GetParameters(row.RowValues, true);

            IData key = KeyTrasformer.ToIData(keys);

            IData find = Index.Find(key);

            Index.Delete(find);

            RowCount = Index.Count();
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
            }

            IData firstKey = KeyTrasformer.ToIData(firstRow.RowValues);
            IData secondKey = KeyTrasformer.ToIData(secondRow.RowValues);

            Index.Delete(firstKey, secondKey);

            RowCount = Index.Count();
        }

        public object[] FindRow(object[] keys)
        {
            IData key = KeyTrasformer.ToIData(keys);
            IData find = Index.Find(key);

            return RecordTransformer.FromIData(find);
        }

        public object[] FindRow(object[] keys, bool findGreater, bool findEqual)
        {
            IData key = KeyTrasformer.ToIData(keys);
            KeyValuePair<IData, IData>? find;

            if (findGreater)
            {
                if (findEqual)
                {
                    find = Index.FindNext(key);

                    if (find.HasValue)
                        return GetRowValues(find.Value.Key, find.Value.Value);
                    else 
                        return null;
                }

                find = Index.FindAfter(key);

                if (find.HasValue)
                    return GetRowValues(find.Value.Key, find.Value.Value);
                else
                    return null;
            }

            if (!findGreater)
            {
                if (!findEqual)
                {
                    find = Index.FindBefore(key);

                    if (find.HasValue)
                        return GetRowValues(find.Value.Key, find.Value.Value);
                    else
                        return null;
                }
            }

            find = Index.FindPrev(key);

            if (find.HasValue)
                return GetRowValues(find.Value.Key, find.Value.Value);
            else
                return null;
        }

        public object[] FirstRow() 
        {
            var firstRow = Index.FirstRow;

            return GetRowValues(firstRow.Key, firstRow.Value);
        }

        public object[] LastRow()
        {
            var lastRow = Index.LastRow;

            return GetRowValues(lastRow.Key, lastRow.Value);
        }

        public bool Contains(object[] keys)
        {
            IData key = KeyTrasformer.ToIData(keys);

            return Index.Exists(key);
        }

        public void Clear()
        {
            Index.Clear();
        }

        #region private methods

        private object[] GetParameters(object[] rowValues, bool isKey) //new name
        {
            List<int> indexes = GetIndexes(isKey);

            return BuildParameters(rowValues, indexes);
        }

        private object[] BuildParameters(object[] rowValues, List<int> indexes) //new name
        {
            if (rowValues == null)
                throw new ArgumentNullException("Row Values cannot be null.");

            if (rowValues.Length == 0)
                throw new Exception("Row Values Length cannot be zero.");

            object[] temp = new object[indexes.Count];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rowValues[indexes[i]];
            }

            return temp;
        }

        private List<int> GetIndexes(bool isKey)
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

            return indexes;
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

        private object[] GetRowValues(IData key, IData record)
        {
            object[] keys = KeyTrasformer.FromIData(key);
            object[] records = RecordTransformer.FromIData(record);

            List<int> indexes = GetIndexes(true);
            List<int> temp = GetIndexes(false);

            foreach (var item in temp)
            {
                indexes.Add(item);
            }

            object[] tmp = new object[keys.Length + records.Length];

            keys.CopyTo(tmp, 0);
            records.CopyTo(tmp, keys.Length);

            return BuildParameters(tmp, indexes);
        }

        #endregion
    }
}
