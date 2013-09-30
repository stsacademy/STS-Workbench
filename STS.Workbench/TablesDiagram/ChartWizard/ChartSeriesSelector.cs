using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STSdb4.Data;
using STS.Workbench.PreviewComponents;
using STS.Workbench.TablesDiagram.TablesDiagramComponents;
using System.Windows.Forms.DataVisualization.Charting;

namespace STS.Workbench.TablesDiagram.ChartWizard
{
    public partial class ChartSeriesSelector : UserControl
    {
        private List<ChartInfo> selectedFields = new List<ChartInfo>();
        private List<KeyValuePair<object[], object[]>> values = new List<KeyValuePair<object[], object[]>>();

        public ChartWizardForm Owner { get; private set; }

        public List<ChartInfo> SelectedFields
        {
            get
            {
                selectedFields.Clear();
                int number = 0;

                foreach (var row in grdViewSeriesSet.Rows)
                {
                    var isChecked = ((DataGridViewRow)row).Cells[0].Value;
                    var seriesName = ((DataGridViewRow)row).Cells[1].Value;

                    selectedFields.Add(new ChartInfo((string)seriesName, number++, (bool)isChecked));
                }

                return selectedFields;
            }
        }

        public ChartSeriesSelector(ChartWizardForm owner)
        {
            Owner = owner;

            InitializeComponent();
            cmbRecords.Text = "5";
            VisibleChanged += ChartSeriesSelector_VisibleChanged;
        }

        private int PageCapacity
        {
            get
            {
                int value = 5;
                Int32.TryParse(cmbRecords.Text, out value);
                return value;
            }
        }


        private void VisualiazeChart()
        {
            if (!Visible)
                return;

            chrtSelected.Series.Clear();
            var selections = SelectedFields;
            if (selections.Count == 0)
                return;

            for (int i = 0; i < selections.Count; i++)
            {
                if (selections[i].IsChecked)
                    chrtSelected.Series.Add(selections[i].SeriesName);
            }

            foreach (var series in chrtSelected.Series)
                series.ChartType = Owner.crtTypesSelector.SelectedChartType;

            foreach (var kv in values)
            {
                int chartCounter = 0;

                for (int i = 0; i < kv.Key.Length; i++)
                {
                    if (selections[i].IsChecked)
                        chrtSelected.Series[chartCounter++].Points.AddY(kv.Key[i]);
                }

                for (int i = 0; i < kv.Value.Length; i++)
                {
                    if (selections[i + kv.Key.Length].IsChecked)
                        chrtSelected.Series[chartCounter++].Points.AddY(kv.Value[i]);
                }
            }
        }

        private void AddVirtualTable()
        {
            var table = new TableComponent(Owner.Table.TableName, Owner.Table.KeyTypes, Owner.Table.RecordTypes);
            table.Lock();
            splitContainer2.Panel1.Controls.Add(table);
            table.Dock = DockStyle.Fill;
            table.CurrentColor = Color.FromArgb(188, 199, 216);
            table.BackColor = Color.FromArgb(188, 199, 216);
            table.MaximumSize = new Size();
        }

        private void SetGridView()
        {
            grdViewSeriesSet.Rows.Clear();
            int counter = 0;

            foreach (var type in Owner.Table.KeyTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, "* " + type);

            foreach (var type in Owner.Table.RecordTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, type);
        }

        private void ChartSeriesSelector_VisibleChanged(object sender, EventArgs e)
        {
            SetGridView();
            VisualiazeChart();
            AddVirtualTable();
        }

        private void btnRefreshChanges_Click(object sender, EventArgs e)
        {
            VisualiazeChart();
        }

        private void grdViewSeriesSet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            VisualiazeChart();
        }

        private void cmbRecords_SelectedValueChanged(object sender, EventArgs e)
        {
            values.Clear();
            foreach (var kv in Owner.Table.Read().Take(PageCapacity))
                values.Add(new KeyValuePair<object[], object[]>(kv.Key, kv.Value));

            VisualiazeChart();
        }
    }
}
