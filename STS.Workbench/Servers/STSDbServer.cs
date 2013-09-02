using STSdb4.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Servers
{
    public class STSDbServer : IServer
    {
        public StorageEngineServer ServerEngine { get; private set; }

        public STSDbServer(StorageEngineServer serverEngine)
        {
            ServerEngine = serverEngine;
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
            get { return "Localhost"; }
        }

        public bool IsWorking
        {
            get { return ServerEngine.IsWorking; }
        }

        public int CountOfConnection
        {
            get { return ServerEngine.TcpServer.ServerConnections.Count; }
        }
    }
}
