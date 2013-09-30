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
    public partial class ServerInstancesControl : UserControl
    {
        Point BegginPoint = new Point(50,50);

        ServerInstanceControl ServerInstanceControl;

        List<Control> ControlList;

        public ServerInstancesControl()
        {
            ControlList = new List<Control>();
            this.ServerInstanceControl = new HomeControls.ServerInstanceControl();

            InitializeComponent();
        }

        private void btnNewServerInstances_Click(object sender, EventArgs e)
        {
            ControlList.Add(ServerInstanceControl);

            ShowAddedControls(ControlList);
        }

        private void ShowAddedControls(List<Control> controlList)
        {
            if (controlList.Count!=0)
            {
                foreach (Control control in controlList)
                {
                    int i = 0; 
                        i ++;

                      //  Label label = (Label)FindForm().FindControlByName("ServerInstancesControl" + i).

                    control.Location = new System.Drawing.Point(BegginPoint.X,BegginPoint.Y);
                    control.Name = "ServerInstanceControl" + i;
                    control.Size = new System.Drawing.Size(150, 100);
                    control.Parent = this;
                    control.Visible = true;
                    BegginPoint.X += 50;
                    
                }
            }
           
        }
    }
}
