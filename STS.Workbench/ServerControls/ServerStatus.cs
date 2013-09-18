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

namespace STS.Workbench.ServerControls
{
    public partial class ServerStatus : UserControl
    {
        private long OldTime = Process.GetCurrentProcess().UserProcessorTime.Ticks;
        public IServer ServerInfo { get; private set; }

        public ServerStatus(IServer serverInfo)
        {
            ServerInfo = serverInfo;
            InitializeComponent();
            Task task = new Task(() => { while (true);});
            task.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CPUUsage.Text = "CPU Usage:" + (Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval) + "%";
            ProgressCPU.Value = (int)(Process.GetCurrentProcess().UserProcessorTime.Ticks - OldTime) / (Environment.ProcessorCount * 100 * timer1.Interval);

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
