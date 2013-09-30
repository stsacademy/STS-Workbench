using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.TablesDiagramComponents
{
    public partial class ChartWizardForm : Form
    {
        private int controlPage = 0;
        private UserControl[] controls;

        public string TableName { get; private set; }
        public DataType[] KeyTypes { get; private set; }
        public DataType[] RecordTypes { get; private set; }

        public ChartWizardForm()
            : this(null, null, null)
        {
        }

        public ChartWizardForm(string tableName, DataType[] keyTypes, DataType[] recordTypes)
        {
            TableName = tableName;
            KeyTypes = keyTypes;
            RecordTypes = recordTypes;

            InitializeComponent();
            ControlsInit();
        }

        private void ControlsInit()
        {
            controls = new UserControl[] { chartTypesSelector, chartSeriesSelector };
            foreach (var control in controls)
            {
                control.Dock = DockStyle.Fill;
                control.Hide();
            }

            SetButtons();
            controls[controlPage].Show();
        }

        private void SetButtons()
        {
            btnBack.Enabled = controlPage > 0;
            btnNext.Enabled = controlPage < controls.Length - 1;
            btnFinish.Enabled = controlPage == controls.Length - 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controls[controlPage].Hide();
            controlPage--;
            controls[controlPage].Show();
            SetButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            controls[controlPage].Hide();
            controlPage++;
            controls[controlPage].Show();
            SetButtons();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
