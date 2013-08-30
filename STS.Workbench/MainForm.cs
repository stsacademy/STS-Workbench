using STS.Workbench.Helpers;
using STS.Workbench.PreviewComponents;
using STS.Workbench.Readers;
using STSdb4.Data;
using STSdb4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            string sys = "stsdb4.sys";
            string dat = "stsdb4.data";

            File.Delete(sys);
            File.Delete(dat);

            IStorageEngine engine = STSdb.FromFile(sys, dat);

            var index1 = engine.OpenXIndex<int, string>("Table1asdasd");
            for (int i = 0; i < 10; i++)
                index1[i] = "gosho " + i;
            
            index1.Flush();

            engine.Commit();

            STSDbConnection STSdbConnection = new STSDbConnection(engine);

            DiagramPreview tablesPreview = new DiagramPreview(STSdbConnection);
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