using STS.Workbench.TablesDiagram.ChartWizard;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace STS.Workbench.TablesDiagram.TablesDiagramComponents
{
    public partial class ChartWizardForm : Form
    {
        private int controlPage = 0;

        private UserControl[] controls;
        private ChartSeriesSelector chartSeriesSelector;
        private ChartTypeSelector chartTypesSelector;

        public ITable Table { get; private set; }

        public SeriesChartType SeriesChartType { get { return chartTypesSelector.SelectedChartType; } }

        public ChartWizardForm(ITable table)
        {
            Table = table;

            InitializeComponent();
            ControlsInit();
        }

        private void ControlsInit()
        {
            chartSeriesSelector = new ChartSeriesSelector(Table);
            chartTypesSelector = new ChartTypeSelector();
            controls = new UserControl[] { chartTypesSelector, chartSeriesSelector };

            foreach (var control in controls)
            {
                splitContainer1.Panel1.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.Hide();
            }

            SetButtons();
            controls[controlPage].Show();
        }

        private void GetSettings(object sender, EventArgs e)
        {

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
