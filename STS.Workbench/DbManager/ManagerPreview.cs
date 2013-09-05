using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS.Workbench.DbManager.DataBases;
using System.Collections;

namespace STS.Workbench.EngineManagers
{
    public partial class ManagerPreview : UserControl
    {
        public TabControl UserControls { get; private set; }

        public ManagerPreview(TabControl tabControl)
        {
            InitializeComponent();

            UserControls = tabControl;
            cbxDataBases.Text = "STSdb4 Embaded";
        }

        private void btnAddDb_Click(object sender, EventArgs e)
        {
            Control controlToAdd = null;
            switch (cbxDataBases.Text)
            {
                case "STSdb4 Embaded":
                    controlToAdd = new STSdb4Embaded();
                    ((STSdb4Embaded)controlToAdd).btnClose.Click += btnClose_Click;
                    ((STSdb4Embaded)controlToAdd).btnEditData.Click += btnEditData_Click;
                    break;
                case "STSdb4 Client":
                    controlToAdd = new STSdb4Client();
                    ((STSdb4Client)controlToAdd).btnClose.Click += btnClose_Click;
                    ((STSdb4Client)controlToAdd).btnEditData.Click += btnEditData_Click;
                    break;
                default:
                    break;
            }

            controlToAdd.Size = new Size(450, 220);

            dbField.Controls.Add(controlToAdd);
            ReOrderControls();

            dbField.ScrollControlIntoView(controlToAdd);
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            foreach (var item in dbField.Controls)
            {
                var control = (Control)item;
                if (control.FindControl((Control)sender))
                {
                    var db = (IDataBase)control;
                    if (db.IsReady)
                    {
                        var page = new TabPage(db.Name);
                        var diagram = new DiagramPreview(db.DbConnection);
                        diagram.Dock = DockStyle.Fill;
                        diagram.btnCloseTab.Click += btnCloseTab_Click;
                        page.Controls.Add(diagram);
                        UserControls.TabPages.Add(page);
                    }
                    break;
                }
            }
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            UserControls.TabPages.Remove(UserControls.SelectedTab);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (var item in dbField.Controls)
            {
                var control = (Control)item;
                if (control.FindControl((Control)sender))
                {
                    dbField.Controls.Remove(control);
                    break;
                }
            }

            ReOrderControls();
        }

        private void ReOrderControls()
        {
            Control[] controls = new Control[dbField.Controls.Count];
            dbField.Controls.CopyTo(controls, 0);
            dbField.Controls.Clear();

            var location = new Point(10, 10);
            foreach (var control in controls)
            {
                var cntrl = (Control)control;
                cntrl.Location = location;

                dbField.Controls.Add(cntrl);
                location = new Point(cntrl.Location.X, cntrl.Location.Y + cntrl.Size.Height + 10);
            }
        }
    }
}
