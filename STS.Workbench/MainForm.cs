using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region DragElemets

        private Point MousePoint = new Point();
        private Control ctrlMoved = new Control();
        private bool IsMoving = false;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MousePoint = e.Location;
                IsMoving = true;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoving = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMoving && e.Button == MouseButtons.Left)
            {
                ctrlMoved = (Control)sender;
                ctrlMoved.Left += e.X - MousePoint.X;
                ctrlMoved.Top += e.Y - MousePoint.Y;
            }
        }

        #endregion
    }
}
