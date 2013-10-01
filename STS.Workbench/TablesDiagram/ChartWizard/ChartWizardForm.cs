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
        public ChartSeriesSelector SeriesFields { get; private set; }
        public ChartTypeSelector SeriesType { get; private set; }

        public SeriesChartType ChartType { get { return SeriesType.SelectedChartType; } }
        public List<ChartInfo> SelectedFields { get { return SeriesFields.SelectedFields; } }

        public ITable Table { get; private set; }

        public ChartWizardForm(ITable table)
        {
            Table = table;

            InitializeComponent();
            ControlsInit();
        }

        private void ControlsInit()
        {
            SeriesFields = new ChartSeriesSelector(this);
            SeriesType = new ChartTypeSelector(this);

            controls = new UserControl[] { SeriesType, SeriesFields };
            foreach (var control in controls)
            {
                splitContainer2.Panel2.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.Hide();
            }

            VisualiazeItems();
        }

        private void VisualiazeItems()
        {
            //buttons
            btnBack.Enabled = controlPage > 0;
            btnNext.Enabled = controlPage < controls.Length - 1;
            btnFinish.Enabled = controlPage == controls.Length - 1;

            //controls
            controls[controlPage].Show();

            //labels
            lblPage.Text = string.Format("{0}. - {1}", controlPage + 1, controls[controlPage].Name);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controls[controlPage].Hide();
            controlPage--;

            VisualiazeItems();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            controls[controlPage].Hide();
            controlPage++;

            VisualiazeItems();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
