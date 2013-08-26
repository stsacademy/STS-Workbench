using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench
{
    public interface ITable
    {
        int PageCapacity { get; }

        string TableName { get; }
        DataType[] KeyTypes { get; }
        DataType[] RecordTypes { get; }

        void Insert(object[] key, object[] record);

        object[] Find(object[] key);

        IEnumerable<KeyValuePair<object[], object[]>> Read();
        IEnumerable<KeyValuePair<object[], object[]>> Read(object[] from, object[] to);
    }

    public interface IConnection
    {
        IEnumerable<ITable> GetSchema();

        ITable OpenTable(string tableName, DataType[] keyTypes, DataType[] recordTypes);
    }
}