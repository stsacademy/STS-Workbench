using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Servers
{
    public interface IServer
    {
        void Start();
        void Stop();

        int Port { get; }
        string DatabaseName { get; }
        string Host { get; }
        long BytesReceive { get; }
        long BytesSent { get; }

        bool IsWorking { get; }

        int CountOfConnection { get; }
    }
}
