﻿using STSdb4.Database;
﻿using STSdb4.Data;
using STSdb4.General;
using STSdb4.Storage;
using STSdb4.WaterfallTree;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.STS_Data_Adapter
{
    class STSDataReader : IDataReader
    {
        #region IDataAdapter

        private STSConnection connection;
        private STSCommand command;
        private Schema.DataTable dbSchemaTable;

        private bool isClosed;
        private bool hasRows;

        private int currentRow = 0;
        public STSDataReader(STSConnection connection, STSCommand command)
        {
            this.connection = connection;
            this.command = command;
        }

        public void Close()
        {
            isClosed = true;
        }

        public int Depth
        {
            get { return 0; }
        }

        public DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

        public bool IsClosed
        {
            get { return isClosed; }
        }

        public bool NextResult()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            if (currentRow < dbSchemaTable.RowCount)
            {
                currentRow++;
                hasRows = true;
                return true;
            }
            return false;
        }

        public int RecordsAffected
        {
            get { return -1; }
        }

        void IDisposable.Dispose()
        {
            this.Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    this.Close();
                }
                catch (Exception e)
                {
                    throw new SystemException("An exception of type " + e.GetType() +
                                              " was encountered while closing the STSDataReader.");
                }
            }
        }

        public int FieldCount
        {
            get { return (int)dbSchemaTable.RowCount * dbSchemaTable.Columns.Length; }
        }

        public bool GetBoolean(int index)
        {
            return (bool)GetFieldValue(index);
        }

        public byte GetByte(int index)
        {
            return (byte)GetFieldValue(index);
        }

        public long GetBytes(int index, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int index)
        {
            return (char)GetFieldValue(index);
        }

        public long GetChars(int index, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int index)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int index)
        {
            return GetFieldValue(index).GetType().ToString();
        }

        public DateTime GetDateTime(int index)
        {
            return (DateTime)GetFieldValue(index); 
        }

        public decimal GetDecimal(int index)
        {
            return (decimal)GetFieldValue(index); 
        }

        public double GetDouble(int index)
        {
            return (double)GetFieldValue(index); 
        }

        public Type GetFieldType(int index)
        {
            return GetFieldValue(index).GetType();
        }

        public float GetFloat(int index)
        {
            return (float)GetFieldValue(index);
        }

        public Guid GetGuid(int index)
        {
            return (Guid)GetFieldValue(index);
        }

        public short GetInt16(int index)
        {
            return (Int16)GetFieldValue(index);
        }

        public int GetInt32(int index)
        {
            return (Int32)GetFieldValue(index);
        }

        public long GetInt64(int index)
        {
            return (Int64)GetFieldValue(index);
        }

        public string GetName(int index)
        {
            return dbSchemaTable.Columns[index].ColumnName;
        }

        public int GetOrdinal(string columnName)
        {
            int i = 0;

            for (i = 0; i < dbSchemaTable.Columns.Length; i++)
            {
                if (dbSchemaTable.Columns[i].ColumnName == columnName)
                {
                    return i;
                }
            }

            throw new IndexOutOfRangeException("Could not find specified column in results");
        }

        public string GetString(int index)
        {
            return (String)GetFieldValue(index);
        }

        public object GetValue(int index)
        {
            return GetFieldValue(index);
        }

        public int GetValues(object[] values)
        {
            int i = 0, j = 0;
            for (; i < values.Length && j < dbSchemaTable.Columns.Length; i++, j++)
            {
                values[i] = GetFieldValue(j);
            }
            return i;
        }

        public bool IsDBNull(int index)
        {
            return GetFieldValue(index) == DBNull.Value;
        }

        public object this[string columnName]
        {
            get
            {
                Schema.Column column = null;

                for (int i = 0; i < dbSchemaTable.Columns.Length; i++)
                {
                    if (dbSchemaTable.Columns[i].ColumnName == columnName)
                    {
                        column = dbSchemaTable.Columns[i];
                    }
                }
                return column;
            }
        }

        public object this[int columnIndex]
        {
            get { return dbSchemaTable.Columns[columnIndex]; }
        }

        #endregion

        private object GetFieldValue(int index)
        {
            if (index > FieldCount || index <= 0)
                throw new IndexOutOfRangeException();

            int columnsLength = dbSchemaTable.Columns.Length;

            int row = (index - 1) / columnsLength;
            int column = (index - 1) - (row * columnsLength);

            return dbSchemaTable.Rows[row].RowValues[column];
        }
    }
}
