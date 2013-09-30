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
        public ITable Table { get; private set; }

        public ChartSeriesSelector(ITable table)
        {
            Table = table;

            InitializeComponent();
            SetGridView();
            AddVirtualTable();
        }

        private void AddVirtualTable()
        {
            TableComponent table = new TableComponent(Table.TableName, Table.KeyTypes, Table.RecordTypes);
            table.Lock();
            splitContainer2.Panel1.Controls.Add(table);
            table.Dock = DockStyle.Fill;
        }

        private void SetGridView()
        {
            int counter = 0;

            foreach (var type in Table.KeyTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, type);

            foreach (var type in Table.RecordTypes)
                grdViewSeriesSet.Rows.Add(true, "Series" + counter++, type);
        }
    }
}
