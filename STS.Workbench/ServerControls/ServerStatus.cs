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
            if (ServerInfo.IsWorking)
                ServerStatusIndicator.BackColor = Color.Green;
            else
                ServerStatusIndicator.BackColor = this.BackColor;  
        }
    }
}
