using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Schema_Table
{
    public class Column
    {
        public string ColumnName;
        public DataType ColumnType;
        public bool IsPrimaryKey;

        public Column(string columnName, DataType columnType, bool isPrimaryKey)
        {
            ColumnName = columnName;
            ColumnType = columnType;
            IsPrimaryKey = isPrimaryKey;
        }
    }
}
