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

        public IEnumerable<ITable> GetSchema()
        {
            foreach (var table in StorageEngine)
                yield return OpenTable(table.Name, table.KeyDescriptor.SlotTypes, table.RecordDescriptor.SlotTypes);
        }

        public ITable OpenTable(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            var index = StorageEngine.OpenXIndex(keyTypes, recordTypes, tableName);

            return new STSDbTable(index);
        }
    }

    public class STSDbTable : ITable
    {
        private DataToObjectsTransformer keyTransfomer;
        private DataToObjectsTransformer recordTransformer;

        public int PageCapacity { get { return 1000; } }

        public string TableName { get { return XIndex.Locator.Name; } }
        public DataType[] KeyTypes { get { return XIndex.Locator.KeyDescriptor.SlotTypes; } }
        public DataType[] RecordTypes { get { return XIndex.Locator.RecordDescriptor.SlotTypes; } }

        public IIndex<IData, IData> XIndex { get; private set; }

        public STSDbTable(IIndex<IData, IData> index)
        {
            if (index == null)
                throw new ArgumentException("storageEngine == null");

            keyTransfomer = new DataToObjectsTransformer(index.Locator.KeyDescriptor.SlotTypes);
            recordTransformer = new DataToObjectsTransformer(index.Locator.RecordDescriptor.SlotTypes);
        }

        public void Insert(object[] key, object[] record)
        {
            XIndex[keyTransfomer.ToIData(key)] = recordTransformer.ToIData(record);
        }

        public object[] Find(object[] key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read()
        {
            foreach (var kv in XIndex.Forward())
                yield return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(kv.Key), recordTransformer.FromIData(kv.Value));
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read(object[] from, object[] to)
        {
            throw new NotImplementedException();
        }
    }

}
