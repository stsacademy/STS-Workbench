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
        }

        private void btnTablesTest_Click(object sender, EventArgs e)
        {
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

        private void btnServer_Click(object sender, EventArgs e)
        {

        }
    }
}