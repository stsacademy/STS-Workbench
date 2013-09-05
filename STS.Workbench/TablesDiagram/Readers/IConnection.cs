﻿using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench
{
    public interface ITable
    {
        string TableName { get; }
        DataType[] KeyTypes { get; }
        DataType[] RecordTypes { get; }

        void Insert(object[] key, object[] record);
        void Delete(object[] key);

        object[] Find(object[] key);
        KeyValuePair<object[], object[]>? FindAfter(object[] key);
        KeyValuePair<object[], object[]>? FindBefore(object[] key);

        IEnumerable<KeyValuePair<object[], object[]>> Read();
        IEnumerable<KeyValuePair<object[], object[]>> Read(object[] fromKey, object[] toKey);

        long Count { get; }

        void Save();
        void Clear();
    }

    public interface IConnection
    {
        string Name { get; }

        IEnumerable<ITable> GetSchema();

        ITable OpenTable(string tableName, DataType[] keyTypes, DataType[] recordTypes);
        void RemoveTable(string tableName, DataType[] keyTypes, DataType[] recordTypes);


        void Commit();
        void Close();
    }
}