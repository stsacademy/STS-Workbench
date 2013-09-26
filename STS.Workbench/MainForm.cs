using STS.Workbench.DbManager.DataBases;
using STS.Workbench.DbManager.Wizards;
using STS.Workbench.EngineManagers;
using STS.Workbench.Helpers;
using STS.Workbench.PreviewComponents;
using STS.Workbench.Readers;
using STS.Workbench.ServerControls;
using STS.Workbench.Servers;
using STS.Workbench.TablesDiagram.Helpers;
using STSdb4.Data;
using STSdb4.Database;
using STSdb4.General.Communication;
using STSdb4.Remote;
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
using STS.Workbench.HomeControls;

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

            var index1 = engine.OpenXIndex<int, string>("Gosho");
            for (int i = 0; i < 10000; i++)
                index1[i] = "gosho " + i;

            var index2 = engine.OpenXIndex<int, string>("table2");
            for (int i = 0; i < 10000; i++)
                index2[i] = "gosho " + i;

            index1.Flush();
            index2.Flush();
            engine.Commit();

            STSDbConnection STSdbConnection = new STSDbConnection(engine);
            TablesDiagramPreview tablesPreview = new TablesDiagramPreview(STSdbConnection);

            var tabPage = new TabPage("Tables");
            tablesPreview.Dock = DockStyle.Fill;
            tablesPreview.btnCloseTab.Click += btnCloseTab_Click;
            tabPage.Controls.Add(tablesPreview);

            userControls.Controls.Add(tabPage);
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            userControls.TabPages.Remove(userControls.SelectedTab);
        }

        private void btnServer_Click(object sender, EventArgs e)
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

            TcpServer server = new TcpServer();
            StorageEngineServer serverEngine = new StorageEngineServer(engine, server);
            STSDbServer statusServer = new STSDbServer(serverEngine);
            statusServer.Start();

            ServerStatus status = new ServerStatus(statusServer);

            var tabPage = new TabPage("Server");

            status.Padding = new Padding(4);
            status.Dock = DockStyle.Fill;
            tabPage.Controls.Add(status);

            userControls.Controls.Add(tabPage);
        }

        private void btnControlTest_Click(object sender, EventArgs e)
        {
            ManagerPreview dbManager = new ManagerPreview(userControls);
            dbManager.Dock = DockStyle.Fill;
            TabPage page = new TabPage("Db Manager");
            page.Controls.Add(dbManager);

            userControls.Controls.Add(page);
        }

        private void btnWizarDbTest_Click(object sender, EventArgs e)
        {
            STSdb4Wizard wizard = new STSdb4Wizard();
            if (wizard.ShowDialog() == DialogResult.OK)
            {
                STSDbConnection STSdbConnection = new STSDbConnection(wizard.StorageEngine);
                TablesDiagramPreview tablesPreview = new TablesDiagramPreview(STSdbConnection);

                var tabPage = new TabPage(STSdbConnection.Name);
                tablesPreview.Dock = DockStyle.Fill;
                tablesPreview.btnCloseTab.Click += btnCloseTab_Click;
                tabPage.Controls.Add(tablesPreview);

                userControls.Controls.Add(tabPage);
            }
        }

        private void btnHomeTest_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            var tabPage = new TabPage("HOME TEST");
            tabPage.Controls.Add(home);

            userControls.Controls.Add(tabPage);
        }
    }
}