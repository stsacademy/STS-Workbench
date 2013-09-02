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
        public IServer ServerInfo { get; private set; }

        public ServerStatus(IServer serverInfo)
        {
            ServerInfo = serverInfo;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName);
            CPUUsage.Text = "CPU Usage:" + process_cpu.NextValue();

            if (ServerInfo.IsWorking)
            {
                ServerStatusIndicator.BackColor = Color.Green;
                Host.Text = "Host:" + ServerInfo.Host;
                Port.Text = "Port:" + ServerInfo.Port.ToString();
            }
            else
            {
                ServerStatusIndicator.BackColor = this.BackColor;
                Host.Text = "Host:";
                Port.Text = "Port:";
            }
        }
    }
}
