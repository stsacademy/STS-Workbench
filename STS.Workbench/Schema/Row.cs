using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Schema
{
    class Row
    {
        public long RowNumber;
        public readonly object[] RowValues;

        public Row(int index, object[] rowValues)
        {
            RowNumber = index;
            RowValues = rowValues;
        }
    }
}
