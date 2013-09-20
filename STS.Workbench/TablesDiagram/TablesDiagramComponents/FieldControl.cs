using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    public partial class FieldControl : UserControl
    {
        public FieldControl()
        {
            InitializeComponent();

            foreach (var item in Controls)
                AttachChildsToEvent((Control)item);
        }

        private void AttachChildsToEvent(Control control)
        {
            control.Click += control_Click;

            foreach (var item in control.Controls)
                AttachChildsToEvent((Control)item);
        }

        private void control_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public void Add(Control control)
        {
            mainField.Controls.Add(control);
        }

        public Point PointToClient(Point p)
        {
            return mainField.PointToClient(p);
        }

        public bool IsScrolledMaxUp()
        {
            return VerticalScroll.Value == 0;
        }

        public bool IsScrolledMaxDown()
        {
            return VerticalScroll.LargeChange == mainField.Bottom;
        }

        public bool IsScrolledMaxRigth()
        {
            return HorizontalScroll.LargeChange == mainField.Right;
        }

        public bool IsScrolledMaxLeft()
        {
            return HorizontalScroll.Value == 0;
        }
    }
}
