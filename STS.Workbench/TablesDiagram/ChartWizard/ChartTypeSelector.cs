using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using STSdb4.Data;
using STS.Workbench.TablesDiagram.TablesDiagramComponents;

namespace STS.Workbench.TablesDiagram.ChartWizard
{
    public partial class ChartTypeSelector : UserControl
    {
        private ToolStripButton LastCheckedButton = null;

        public SeriesChartType SelectedChartType { get { return FindChartType(); } }
        public ChartWizardForm Owner { get; private set; }

        public ChartTypeSelector(ChartWizardForm owner)
        {
            Owner = owner;

            InitializeComponent();
            LastCheckedButton = toolStripButtonLine;

            foreach (var item in toolStrip1.Items)
                ((ToolStripItem)item).Click += toolButton_Click;
        }

        private void toolButton_Click(object sender, EventArgs e)
        {
            var button = (ToolStripButton)sender;

            LastCheckedButton.Checked = false;
            button.Checked = true;
            LastCheckedButton = button;
        }

        private SeriesChartType FindChartType()
        {
            switch (LastCheckedButton.Text)
            {
                case "Area":
                    return SeriesChartType.Area;
                case "Bar":
                    return SeriesChartType.Bar;
                case "BoxPlot":
                    return SeriesChartType.BoxPlot;
                case "Line":
                    return SeriesChartType.Line;
                case "Point":
                    return SeriesChartType.Point;

                default:
                    return SeriesChartType.Line;
            }
        }
    }
}
