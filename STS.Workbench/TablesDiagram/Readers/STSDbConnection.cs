using STS.Workbench.Helpers;
using STSdb4.Data;
using STSdb4.Database;
using STSdb4.Storage;
using STSdb4.WaterfallTree;
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

        public ITable OpenTable(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            return new STSDbTable(StorageEngine, tableName, keyTypes, recordTypes);
        }

        public void RemoveTable(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            StorageEngine.Delete(tableName);
        }

        public void Commit()
        {
            StorageEngine.Commit();
        }

        public void Close()
        {
            StorageEngine.Close();
        }
    }

    public class STSDbTable : ITable
    {
        private StringObjectToIDataTransformer keyTransfomer;
        private StringObjectToIDataTransformer recordTransformer;

        private IIndex<IData, IData> XIndex;

        public string TableName { get; private set; }

        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        public long ID { get; private set; }
        public DateTime CreateTime { get; private set; }

        public STSDbTable(IStorageEngine engine, string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            if (engine == null)
                throw new ArgumentException("engine == null");

            XIndex = engine.OpenXIndex(keyTypes, recordTypes, tableName);
            var schemeRecord = engine.Find(tableName);

            ID = schemeRecord.ID;
            CreateTime = schemeRecord.CreateTime;

            TableName = tableName;
            KeyTypes = keyTypes;
            RecordTypes = recordTypes;

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

        public KeyValuePair<object[], object[]>? FindAfter(object[] key)
        {
            var after = XIndex.FindAfter(keyTransfomer.ToIData(key));

            if (after.HasValue)
                return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(after.Value.Key), recordTransformer.FromIData(after.Value.Value));

            return null;
        }

        public KeyValuePair<object[], object[]>? FindBefore(object[] key)
        {
            var before = XIndex.FindBefore(keyTransfomer.ToIData(key));

            if (before.HasValue)
                return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(before.Value.Key), recordTransformer.FromIData(before.Value.Value));

            return null;
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read()
        {
            return Read(null, null);
        }

        public IEnumerable<KeyValuePair<object[], object[]>> Read(object[] fromKey, object[] toKey)
        {
            bool hasFrom = fromKey != null;
            bool hasTo = toKey != null;

            var from = hasFrom ? keyTransfomer.ToIData(fromKey) : null;
            var to = hasTo ? keyTransfomer.ToIData(toKey) : null;

            foreach (var kv in XIndex.Forward(from, hasFrom, to, hasTo))
                yield return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(kv.Key), recordTransformer.FromIData(kv.Value));
        }

        public IEnumerable<KeyValuePair<object[], object[]>> ReadReverse()
        {
            return ReadReverse(null, null);
        }

        public IEnumerable<KeyValuePair<object[], object[]>> ReadReverse(object[] fromKey, object[] toKey)
        {
            bool hasFrom = fromKey != null;
            bool hasTo = toKey != null;

            var from = hasFrom ? keyTransfomer.ToIData(fromKey) : null;
            var to = hasTo ? keyTransfomer.ToIData(toKey) : null;

            foreach (var kv in XIndex.Backward(from, hasFrom, to, hasTo))
                yield return new KeyValuePair<object[], object[]>(keyTransfomer.FromIData(kv.Key), recordTransformer.FromIData(kv.Value));
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