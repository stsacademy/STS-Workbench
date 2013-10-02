using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.HomeControls
{
    public partial class ServerInstanceControl : UserControl
    {
        private string InstanceName { get; set; }
        private string Host { get; set; }
        private string Port { get; set; }

        public ServerInstanceControl(string name, string host, string port)
        {
            InitializeComponent();

            InstanceName = name;
            Host = host;
            Port = port;

            lblName.Text = name;
            lblHost.Text = host;
            lblPort.Text = port;
        }

        private void ServerInstanceControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.Aqua;
        }

        private void ServerInstanceControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }
    }
}
