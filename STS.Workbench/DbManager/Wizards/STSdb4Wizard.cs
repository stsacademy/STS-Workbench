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

namespace STS.Workbench.DbManager.Wizards
{
    public partial class STSdb4Wizard : Form
    {
        public STSdb4Wizard()
        {
            InitializeComponent();

            Size = new Size(800, 300);
            MinimumSize = new Size(800, 300);
            OnCheck(this, new EventArgs());
            btnSubmit.Size = new Size(0, 0);
        }

        public bool ClientSelected { get { return rbtnClient.Checked; } }
        public bool CreateNewSelected { get { return rbtnCreateNew.Checked; } }

        public string Host { get { return tbxHost.Text; } }
        public int Port { get { return Int32.Parse(tbxPort.Text); } }

        public string SystemFilePath { get { return CreateNewSelected ? Path.Combine(FolderPath, SystemFileName) : tbxSystemFilePath.Text; } }
        public string DataFilePath { get { return CreateNewSelected ? Path.Combine(FolderPath, DataFileName) : tbxDataFilePath.Text; } }

        public string SystemFileName { get { return tbxDataFileName.Text; } }
        public string DataFileName { get { return tbxSystemFileName.Text; } }

        public string FolderPath { get { return tbxFolderPath.Text; } }

        public IStorageEngine StorageEngine { get; private set; }

        private void OnCheck(object sender, EventArgs e)
        {
            splitContainer3.Panel1Collapsed = !rbtnClient.Checked;
            splitContainer3.Panel2Collapsed = rbtnClient.Checked;

            splitContainer6.Panel1Collapsed = rbtnOpen.Checked;
            splitContainer6.Panel2Collapsed = !rbtnOpen.Checked;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreateNewSelected)
                {
                    if (File.Exists(SystemFilePath))
                    {
                        if (MessageBox.Show(string.Format("File : {0}, alredy exist.\n\r Do you want to overwrite it?", SystemFilePath), "File conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            File.Delete(SystemFilePath);
                    }
                    if (File.Exists(DataFilePath))
                    {
                        if (MessageBox.Show(string.Format("File : {0}, alredy exist.\n\r Do you want to overwrite it?", DataFilePath), "File conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            File.Delete(SystemFilePath);
                    }
                }

                StorageEngine = ClientSelected ? STSdb.FromNetwork(Host, Port) : STSdb.FromFile(DataFilePath);
                btnSubmit.PerformClick();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tbxFolderPath.Text = dialog.SelectedPath;
        }

        private void btnBrowseSystemFile_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tbxSystemFilePath.Text = dialog.FileName;
        }

        private void btnBrowseDataFile_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                tbxDataFilePath.Text = dialog.FileName;
        }
    }
}