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
using STS.Workbench.TablesDiagram.TablesDiagramComponents;

namespace STS.Workbench
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Random rand = new Random();

        public class Tick
        {
            public string symbol;
            public double Bid;
            public double Ask;
        }

        public static Tick GetRandomTick()
        {
            Tick tick = new Tick();
            tick.symbol = "Q";
            tick.Bid = rand.Next(0, 4) + rand.NextDouble();
            tick.Ask = rand.Next(0, 4) + rand.NextDouble();

            return tick;
        }

        private void btnTablesTest_Click(object sender, EventArgs e)
        {
            string file = "stsdb4.data";
            File.Delete(file);

            IStorageEngine engine = STSdb.FromFile(file);

            var table1 = engine.OpenXIndex<int, string>("table1");
            for (int i = 0; i < 10000; i++)
                table1[i] = "record N: " + i;

            var table2 = engine.OpenXIndex<int, Tick>("ticks");

            for (int i = 0; i < 20000; i++)
            {
                table2[i] = GetRandomTick();
            }

            table2.Flush();
            table1.Flush();
            engine.Commit();

            STSDbConnection STSdbConnection = new STSDbConnection(engine);
            TablesDiagramPreview tablesPreview = new TablesDiagramPreview(STSdbConnection);

            var tabPage = new TabPage("Tables");
            tablesPreview.Dock = DockStyle.Fill;
            tabPage.Controls.Add(tablesPreview);

            userControls.Controls.Add(tabPage);
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            userControls.TabPages.Remove(userControls.SelectedTab);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            string file = "stsdb4.data";

            File.Delete(file);

            IStorageEngine engine = STSdb.FromFile(file);

            var index1 = engine.OpenXIndex<int, string>("Table1asdasd");
            for (int i = 0; i < 10; i++)
                index1[i] = "gosho " + i;

            index1.Flush();

            engine.Commit();

            TcpServer server = new TcpServer();
            StorageEngineServer serverEngine = new StorageEngineServer(engine, server);
            STSDbServer statusServer = new STSDbServer(serverEngine, true);
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

        private void btnChartTest_Click(object sender, EventArgs e)
        {
            ChartWizardForm chart = new ChartWizardForm();
            chart.Show();
        }
    }
}