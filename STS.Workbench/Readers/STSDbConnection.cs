using STS.Workbench.Helpers;
using STSdb4.Data;
using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Readers
{
    public class STSDbConnection : IConnection
    {
        public IStorageEngine StorageEngine { get; private set; }

        public STSDbConnection(IStorageEngine storageEngine)
        {
            if (storageEngine == null)
                throw new ArgumentException("storageEngine == null");

            StorageEngine = storageEngine;
        }

        public string Name { get { return "STSdb4"; } }

        public IEnumerable<ITable> GetSchema()
        {
            foreach (var table in StorageEngine)
                yield return OpenTable(table.Name, table.KeyDescriptor.SlotTypes, table.RecordDescriptor.SlotTypes);
        }

        public void Commit()
        {
            StorageEngine.Commit();
        }

        public ITable OpenTable(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            var index = StorageEngine.OpenXIndex(keyTypes, recordTypes, tableName);

            return new STSDbTable(index);
        }

        public void RemoveTable(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            StorageEngine.Delete(tableName);
        }
    }

    public class STSDbTable : ITable
    {
        private StringObjectToIDataTransformer keyTransfomer;
        private StringObjectToIDataTransformer recordTransformer;

        public int PageCapacity { get { return 1000; } }

        public string TableName { get; private set; }
        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }


        public IIndex<IData, IData> XIndex { get; private set; }

        public STSDbTable(IIndex<IData, IData> index)
        {
            if (index == null)
                throw new ArgumentException("storageEngine == null");

            XIndex = index;

            TableName = XIndex.Locator.Name;
            KeyTypes = XIndex.Locator.KeyDescriptor.SlotTypes;
            RecordTypes = XIndex.Locator.RecordDescriptor.SlotTypes;

            keyTransfomer = new StringObjectToIDataTransformer(KeyTypes);
            recordTransformer = new StringObjectToIDataTransformer(RecordTypes);
        }

        public void Insert(object[] key, object[] record)
        {
            XIndex[keyTransfomer.ToIData(key)] = recordTransformer.ToIData(record);
        }

        public void Delete(object[] key)
        {
            XIndex.Delete(keyTransfomer.ToIData(key));
        }

        public object[] Find(object[] key)
        {
            return recordTransformer.FromIData(XIndex.Find(keyTransfomer.ToIData(key)));
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read()
        {
            foreach (var kv in XIndex.Forward())
                yield return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(kv.Key), recordTransformer.FromIData(kv.Value));
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read(object[] fromKey, object[] toKey)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            XIndex.Flush();
        }

        public void Clear()
        {
            XIndex.Clear();
        }
    }
}
