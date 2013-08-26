using STS.Workbench.PreviewComponents;
using STSdb4.Data;
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

            TablesPreview tablesPreview = new TablesPreview(null);
            Controls.Add(tablesPreview);
        }

        #region DragElemets

        private Point MousePoint = new Point();
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
                Control control = (Control)sender;
                control.Left += e.X - MousePoint.X;
                control.Top += e.Y - MousePoint.Y;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            TableComponent cntr = new TableComponent();
            cntr.Location = new Point(1200, 500);
            Controls.Add(cntr);
        }
    }
}