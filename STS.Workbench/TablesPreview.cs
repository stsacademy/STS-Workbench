using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STS.Workbench.PreviewComponents;
using STSdb4.Data;

namespace STS.Workbench
{
    public partial class TablesPreview : UserControl
    {
        private Dictionary<int, TableComponent> tables = new Dictionary<int, TableComponent>();
        public Control LastClickedTable { get; private set; }

        public TablesPreview()
        {
            InitializeComponent();

            splitContainer4.Panel1Collapsed = true;
        }

        #region TableVisualization

        private Point MousePoint = new Point();
        private bool IsMoving = false;
        private bool IsPlacing = false;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MousePoint = e.Location;
                IsMoving = true;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            IsMoving = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (IsMoving && e.Button == MouseButtons.Left)
            {
                Control control = (Control)sender;
                control.Left += e.X - MousePoint.X;
                control.Top += e.Y - MousePoint.Y;
            }
        }

        #endregion

        private void btnPlaceTable_Click(object sender, EventArgs e)
        {
            if (IsPlacing)
                return;

            IsPlacing = true;
            splitContainer4.Panel1Collapsed = false;
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            ucrlTablesField.Controls.Remove(LastClickedTable);
        }

        private void ucrlTablesField_Click(object sender, EventArgs e)
        {
            if (IsPlacing)
            {
                TableComponent table = new TableComponent(ucrlTablesField.PointToClient(MousePosition), new Size(160, 200), tableAddComponent.TableName, tableAddComponent.KeyTypes, tableAddComponent.RecordTypes);
                table.MouseDown += OnMouseDown;
                table.MouseUp += OnMouseUp;
                table.MouseMove += OnMouseMove;
                table.Click += table_Click;

                ucrlTablesField.Controls.Add(table);

                IsPlacing = false;
                splitContainer4.Panel1Collapsed = true;
            }
        }

        private void table_Click(object sender, EventArgs e)
        {
            LastClickedTable = (Control)sender;
        }
    }
}
