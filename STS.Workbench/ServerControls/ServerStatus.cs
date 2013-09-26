using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS.Workbench.Servers;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace STS.Workbench.ServerControls
{
    public partial class ServerStatus : UserControl
    {
        private long OldTime = Process.GetCurrentProcess().UserProcessorTime.Ticks;
        private float OldByteTranfer;

        private PerformanceCounter NetworkSentBytesPC;
        private PerformanceCounter NetworkReceivedBytesPC;

        public IServer ServerInfo { get; private set; }

        public ServerStatus(IServer serverInfo)
        {
            ServerInfo = serverInfo;
            InitializeComponent();
            PerformanceCounterCategory Array = new PerformanceCounterCategory(".NET CLR Networking");
            var c = Array.InstanceExists("_global_");
            TcpClient client = new TcpClient();
            client.Connect("194.153.145.104", 80);


            NetworkSentBytesPC = new PerformanceCounter(".NET CLR Networking", "Bytes Sent");
            NetworkReceivedBytesPC = new PerformanceCounter(".NET CLR Networking", "Bytes Received");
            OldByteTranfer = NetworkSentBytesPC.NextValue() + NetworkReceivedBytesPC.NextValue();

            Task task = new Task(() => { while (true);});
            task.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CPUUsage.Text = "CPU\n" + (Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval) + "%";

            CPUProgress.Value = (int)(Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval);

            DatabaseName.Text = "Database Name:" + ServerInfo.DatabaseName;
            if (ServerInfo.IsWorking)
            {
                ServerStatusIndicator.BackColor = Color.Green;
                Host.Text = "Host:" + ServerInfo.Host;
                Port.Text = "Port:" + ServerInfo.Port.ToString();
                Connections.Text = "Connections" + ServerInfo.CountOfConnection.ToString();
            }
            else
            {
                ServerStatusIndicator.BackColor = this.BackColor;
                Host.Text = "Host:";
                Port.Text = "Port:";
                Connections.Text = "Connections";
            }

            OldTime = Process.GetCurrentProcess().UserProcessorTime.Ticks;
        }
    }
}
