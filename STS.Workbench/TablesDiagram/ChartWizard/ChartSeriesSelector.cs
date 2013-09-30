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

namespace STS.Workbench.TablesDiagram.ChartWizard
{
    public partial class ChartSeriesSelector : UserControl
    {
        private int PageCapacity { get { return Int32.Parse(cmbRecords.Text); } }
        private List<ChartInfo> selectedFields = new List<ChartInfo>();

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

        private void ChartSeriesSelector_VisibleChanged(object sender, EventArgs e)
        {
            SetGridView();
            VisualiazeChart();
            AddVirtualTable();
        }

        private void VisualiazeChart()
        {
            foreach (var series in chrtSelected.Series)
                series.ChartType = Owner.crtTypesSelector.SelectedChartType;
        }

        private void AddVirtualTable()
        {
            var table = new TableComponent(Owner.Table.TableName, Owner.Table.KeyTypes, Owner.Table.RecordTypes);
            table.Lock();
            splitContainer2.Panel1.Controls.Add(table);
            table.Dock = DockStyle.Fill;
        }

        private void SetGridView()
        {
            grdViewSeriesSet.Rows.Clear();
            int counter = 0;

            foreach (var type in Owner.Table.KeyTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, type);

            foreach (var type in Owner.Table.RecordTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, type);
        }

        private void btnRefreshChanges_Click(object sender, EventArgs e)
        {
            var record = Owner.Table.Read().Take(PageCapacity);

            foreach (var kv in record)
            {
                for (int i = 0; i < kv.Key.Length; i++)
                {

                }
            }
        }
    }
}
