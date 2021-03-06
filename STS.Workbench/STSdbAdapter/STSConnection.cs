﻿﻿using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace STS.Workbench.STS_Data_Adapter
{
    class STSConnection : IDbConnection
    {
        #region IDbConnection

        private IStorageEngine engine;
        private ConnectionState state;

        private string dataBase;
        private string version;

        private string systemFile;
        private string dataFile;

        public string ConnectionString { get; set; }

        public IStorageEngine Engine { get { return engine; } }

        public ConnectionState State { get { return state; } }

        public string Database { get { return dataBase; } }

        public string ServerVersion { get { return version; } }

        public string DataSource { get { return dataFile; } }

        public string SystemSource { get { return systemFile; } }

        public int ConnectionTimeout { get; set; }

        public STSConnection()
        {
            state = ConnectionState.Closed;
        }
        public STSConnection(string connectionString)
            : this()
        {
            ConnectionString = connectionString;
        }
       
        public void ChangeDatabase(string connectionString)
        {       
            Close();

            ConnectionString = connectionString;

            Open();
        }

        public void Close()
        {
            engine.Close();
            state = ConnectionState.Closed;
        }

        public IDbCommand CreateCommand()
        {
            return new STSCommand();
        }

        public void Open()
        {
            //if (IsValidConnectionString())
            //    engine = STSdb.FromFile(systemFile, dataFile);
            //else
            //    throw new Exception("Connection failed.");

            state = ConnectionState.Open;
        }

        //@"Provider=STSDb.4.0;System Source=D:\stsdb4.sys;Data Source=D:\stsdb4.dat"
        private bool IsValidConnectionString()
        {
            if (ConnectionString == null)
                return false;

            string[] fields = ConnectionString.Split(';');

            try
            {
                dataBase = fields[0].Substring(9, 5);
                version = fields[0].Substring(15);

                string[] _systemFile = fields[1].Split('\\');
                systemFile = _systemFile[_systemFile.Length - 1];

                string[] _dataFile = fields[2].Split('\\');
                dataFile = _dataFile[_dataFile.Length - 1];
            }
            catch { return false; }

            if (dataBase != "STSDb" || version != "4.0" || !File.Exists(systemFile) || !File.Exists(dataFile))
                return false;

            return true;
        }

        void IDisposable.Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
            
            engine.Dispose();
            Close();
            
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
                                              " was encountered while closing the STSConnection.");
                }
            }
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
