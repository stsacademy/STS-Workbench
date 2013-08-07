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

        public byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        public IDataReader GetData(int i)
        {
            throw new NotImplementedException();
        }

        public string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        public double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        public Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        public float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        public Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        public short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        public int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        public long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        public string GetName(int i)
        {
            throw new NotImplementedException();
        }

        public int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        public string GetString(int i)
        {
            throw new NotImplementedException();
        }

        public object GetValue(int i)
        {
            throw new NotImplementedException();
        }

        public int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }

        public bool IsDBNull(int i)
        {
            throw new NotImplementedException();
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
