using STSdb4.General.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace STS.Workbench.HomeControls
{
    public partial class ServerInstancesControl : UserControl
    {
        List<Control> ControlList;

        int i = 1;

        Label ServerInstanceInformation = new Label();

        public ServerInstancesControl()
        {

            ControlList = new List<Control>();

            InitializeComponent();
        }

        private void btnNewServerInstances_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ControlList.Add(new ServerInstanceControl("Gosho" + i, Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString(), "7182"));

                ShowAddedControls(ControlList);

                i++;
            }
        }

        private void ShowAddedControls(List<Control> controlList)
        {
            if (controlList.Count != 0)
            {
                int newControlIndex = 0;
                Point begginPoint = new Point(30, 48);

                foreach (Control control in controlList)
                {
                    newControlIndex++;

                    control.Name = "ServerInstanceControl" + newControlIndex;
                    control.Location = new System.Drawing.Point(begginPoint.X, begginPoint.Y);
                    control.Size = new System.Drawing.Size(180, 120);
                    control.Parent = this;
                    control.Visible = true;

                    if (begginPoint.X < 1000)
                        begginPoint.X += 200;
                    else
                    {
                        begginPoint.X = 30;
                        begginPoint.Y += 140;
                    }
                }
            }
        }
    }
}
