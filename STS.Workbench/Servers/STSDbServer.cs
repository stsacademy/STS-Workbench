using STSdb4.General.Communication;
using STSdb4.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Servers
{
    public class STSDbServer : IServer
    {
        private bool errorsLog;

        public StorageEngineServer ServerEngine { get; private set; }

        public STSDbServer(StorageEngineServer serverEngine)
            : this(serverEngine, true)
        {
        }

        public STSDbServer(StorageEngineServer serverEngine, bool errorsLog)
        {
            ServerEngine = serverEngine;
            this.errorsLog = errorsLog;
        }

        public void Start()
        {
            ServerEngine.Start();
        }

        public void Stop()
        {
            ServerEngine.Stop();
        }

        public int Port
        {
            get { return ServerEngine.TcpServer.Port; }
        }

        public string Host
        {
            get { return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString(); }
        }

        public string DatabaseName
        {
            get { return "STSdb4"; }
        }

        public bool IsWorking
        {
            get { return ServerEngine.IsWorking; }
        }

        public int CountOfConnection
        {
            get { return ServerEngine.TcpServer.ServerConnections.Count; }
        }


        public long BytesReceive
        {
            get { return ServerEngine.TcpServer.BytesReceive; }
        }

        public long BytesSent
        {
            get { return ServerEngine.TcpServer.BytesSent; }
        }


        public bool ErrorsLog
        {
            get { return errorsLog; }
        }

        public Queue<KeyValuePair<DateTime, string>> Errors
        {
            get 
            {
                if (!ErrorsLog)
                    throw new ArgumentException("!ErrorsLog");

                Queue<KeyValuePair<DateTime, string>> errors = new Queue<KeyValuePair<DateTime,string>>();

                while (Errors.Count > 100)
                {
                    KeyValuePair<DateTime,Exception> error;

                    if (ServerEngine.TcpServer.Errors.TryDequeue(out error))
                        errors.Enqueue(new KeyValuePair<DateTime, string>(error.Key, error.Value.Message));
                }

                return errors;
            }
        }

        public long DBSize
        {
            get { return ServerEngine.StorageEngine.Size; }
        }


        public IEnumerable<IServerConnection> Connections
        {
            get 
            {
                foreach (var connection in ServerEngine.TcpServer.ServerConnections)
                    yield return new STSDbServerConnection(connection.Key);
            }
        }
    }

    public class STSDbServerConnection : IServerConnection
    {
        public ServerConnection Connection { get; private set; }

        public STSDbServerConnection(ServerConnection connection)
        {
        }

        public string Name
        {
            get { return IPAddress.Parse(((IPEndPoint)Connection.TcpClient.Client.RemoteEndPoint).Address.ToString()).ToString(); }
        }

        public void Disconnect()
        {
            Connection.Disconnect();
        }


        public bool IsConnected
        {
            get { return Connection.IsConnected; }
        }
    }
}
