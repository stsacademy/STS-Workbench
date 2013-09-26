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
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace STS.Workbench.ServerControls
{
    public partial class ServerStatus : UserControl
    {
        private long OldTime = Process.GetCurrentProcess().UserProcessorTime.Ticks;
        private float OldByteTransfer;

        public IServer ServerInfo { get; private set; }

        public ServerStatus(IServer serverInfo)
        {
            ServerInfo = serverInfo;
            InitializeComponent();

            TrafficProgress.MaxValue = (int)NetworkInterface.GetAllNetworkInterfaces()[0].Speed / 800;
            OldByteTransfer = ServerInfo.BytesReceive + ServerInfo.BytesSent;
            Task task = new Task(() => { while (true);});
            task.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CPUUsage.Text = "CPU\n" + (Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval) + "%";
            CPUProgress.Value = (int)(Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval);

            Traffic.Text = "Traffic\n"+(ServerInfo.BytesReceive + ServerInfo.BytesSent-OldByteTransfer)/timer1.Interval + " Bytes/s";
            TrafficProgress.Value = (int)(ServerInfo.BytesReceive + ServerInfo.BytesSent - OldByteTransfer) / timer1.Interval;

            DatabaseName.Text = "Database Name:" + ServerInfo.DatabaseName;
            if (ServerInfo.IsWorking)
            {
                ServerStatusIndicator.BackColor = Color.Green;

                if (ServerInfo.ErrorsLog)
                    ErrorsLogIndicator.BackColor = Color.Green;

                Host.Text = "Host:" + ServerInfo.Host;
                Port.Text = "Port:" + ServerInfo.Port.ToString();
                DBSize.Text = "Database Size:" + (ServerInfo.DBSize / (1024 * 1024)) + "MB";
                Connections.Text = "Connections" + ServerInfo.CountOfConnection.ToString();
            }
            else
            {
                ErrorsLogIndicator.BackColor = this.BackColor;
                ServerStatusIndicator.BackColor = this.BackColor;
                Host.Text = "Host:";
                Port.Text = "Port:";
                DBSize.Text = "Database Size:";
                Connections.Text = "Connections";
            }

            OldTime = Process.GetCurrentProcess().UserProcessorTime.Ticks;
            OldByteTransfer = ServerInfo.BytesReceive + ServerInfo.BytesSent;
        }
    }
}
