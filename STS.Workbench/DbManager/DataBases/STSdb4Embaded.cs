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
    public partial class STSdb4Embaded : UserControl, IDataBase
    {
        public STSdb4Embaded()
        {
            InitializeComponent();
            splitContainer6.Panel1Collapsed = true;
        }

        private STSDbConnection STSDbConnection;

        public bool IsReady { get; private set; }
        public IConnection DbConnection { get { return STSDbConnection; } }

        public void Open()
        {
            try
            {
                if (CreateNew)
                {
                    File.Delete(SystemFilePath);
                    File.Delete(DataFilePath);
                }

                IStorageEngine engine = STSdb.FromFile(SystemFilePath, DataFilePath, true);
                STSDbConnection = new STSDbConnection(engine);

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

        public string SystemFilePath
        {
            get { return CreateNew ? Path.Combine(FolderPath, SystemFileName) : txbSystemFilePath.Text; }
        }
        public string DataFilePath
        {
            get { return CreateNew ? Path.Combine(FolderPath, DataFileName) : txbDataFilePath.Text; }
        }

        public string FolderPath { get { return tbxFoldePath.Text; } }
        public string SystemFileName { get { return tbxSystemFileName.Text; } }
        public string DataFileName { get { return tbxDataFileName.Text; } }

        public bool CreateNew { get { return rbtnCreateNewDb.Checked; } }

        private void rbtnOpenDb_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer6.Panel1Collapsed = !rbtnOpenDb.Checked;
            splitContainer6.Panel2Collapsed = rbtnOpenDb.Checked;
        }

        private void btnBrwSystem_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                txbSystemFilePath.Text = dialog.FileName;
        }

        private void btnBrwData_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                txbDataFilePath.Text = dialog.FileName;
        }

        private void btnBroseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tbxFoldePath.Text = dialog.SelectedPath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (IsReady)
            {
                
            }
        }

        private void btnOpenDb_Click(object sender, EventArgs e)
        {
            Open();
        }
    }
}
