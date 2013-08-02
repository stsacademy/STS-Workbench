using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.STS_Data_Adapter
{
    class STSCommand : IDbCommand
    {
        //fields
        public string commandText;
        public int commandTimeout;
        public CommandType commandType;
        STSConnection connection;

        //properties
        public string CommandText
        {
            get { return commandText; }
            set { commandText = value; }
        }

        public int CommandTimeout
        {
            get { return commandTimeout; }
            set { commandTimeout = value; }
        }

        public CommandType CommandType
        {
            get { return commandType; }
            set { commandType = value; }
        }

        public STSConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public IDbTransaction Transaction
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public UpdateRowSource UpdatedRowSource
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //constructors
        public STSCommand()
        {
        }

        public STSCommand(string cmdText)
        {
            commandText = cmdText;
        }

        public STSCommand(string cmdText, STSConnection dbConnection)
        {
            commandText = cmdText;
            connection = dbConnection;
        }

        #region Methods

        //methods
        public IDbDataParameter CreateParameter()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }

        public IDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        public IDataParameterCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
