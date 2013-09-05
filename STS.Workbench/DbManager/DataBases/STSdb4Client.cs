using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS.Workbench.Readers;
using System.IO;
using STSdb4.Database;

namespace STS.Workbench.DbManager.DataBases
{
    public partial class STSdb4Client : UserControl, IDataBase
    {
        public STSdb4Client()
        {
            InitializeComponent();
        }

        private STSDbConnection STSDbConnection;

        public bool IsReady { get; private set; }
        public IConnection DbConnection { get { return STSDbConnection; } }

        public void Open()
        {
            try
            {
                IsReady = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Failed to open table. \r\n Error: {0}", e.ToString()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsReady = false;
            }
            finally
            {
                btnOpenDb.Enabled = !IsReady;
            }
        }
                
        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnEditData_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDb_Click(object sender, EventArgs e)
        {
            Open();
        }
    }
}
