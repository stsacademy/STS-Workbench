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
        private Dictionary<string, TableComponent> tables = new Dictionary<string, TableComponent>();
        public TableComponent ActiveTable { get; private set; }

        public readonly IConnection DbConnection;

        public TablesPreview(IConnection dbConnection)
        {
            DbConnection = dbConnection;

            InitializeComponent();
            splitContainer4.Panel1Collapsed = true;
        }

        #region TableMoves

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
                Control control = ((Control)sender).Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                if (control.GetType() == typeof(TableComponent))
                {
                    control.Left += e.X - MousePoint.X;
                    control.Top += e.Y - MousePoint.Y;
                }
            }
        }

        #endregion

        private void btnPlaceTable_Click(object sender, EventArgs e)
        {
            if (!IsPlacing)
            {
                tableAddComponent.ResetFields();
                splitContainer4.Panel1Collapsed = false;
                IsPlacing = true;
            }
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            if (ActiveTable != null)
                RemoveTable(ActiveTable);
        }

        private void btnCancelTable_Click(object sender, EventArgs e)
        {
            IsPlacing = false;
            splitContainer4.Panel1Collapsed = true;
        }

        private void AddTable(TableComponent table)
        {
            DbConnection.OpenTable(table.Name, table.KeyTypes, table.RecordTypes);

            tables.Add(table.TableName, table);
            ucrlTablesField.Controls.Add(table);
            treeViewTablesCatalog.Nodes[0].Nodes.Add(table.TableName, table.TableName);
            treeViewTablesCatalog.ExpandAll();

            //set events
            table.pbMoveIcon.MouseDown += OnMouseDown;
            table.pbMoveIcon.MouseUp += OnMouseUp;
            table.pbMoveIcon.MouseMove += OnMouseMove;

            table.pbTable.Click += table_Click;
            table.pbTable.MouseDoubleClick += table_DoubleClick;
        }

        private void RemoveTable(TableComponent table)
        {
            ucrlTablesField.Controls.Remove(table);
            tables.Remove(table.TableName);
            treeViewTablesCatalog.Nodes[0].Nodes.RemoveByKey(table.TableName);
        }

        private void ucrlTablesField_Click(object sender, EventArgs e)
        {
            if (IsPlacing)
            {
                TableComponent t;
                if (tables.TryGetValue(tableAddComponent.TableName, out t))
                {
                    MessageBox.Show(String.Format("'{0}', alredy exist!", tableAddComponent.TableName), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TableComponent table = new TableComponent(tableAddComponent.TableName, tableAddComponent.KeyTypes, tableAddComponent.RecordTypes);
                table.Location = ucrlTablesField.PointToClient(MousePosition);

                AddTable(table);

                splitContainer4.Panel1Collapsed = true;
                IsPlacing = false;
            }
        }

        private void table_Click(object sender, EventArgs e)
        {
            var cntrl = ((Control)sender).Parent.Parent.Parent.Parent.Parent.Parent.Parent;
            var table = (TableComponent)cntrl;

            var node = treeViewTablesCatalog.Nodes[0].Nodes.Find(table.TableName, true)[0];
            treeViewTablesCatalog.SelectedNode = node;

            MarkTable(table);
        }

        private void table_DoubleClick(object sender, EventArgs e)
        {

        }

        private void treeViewTablesCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewTablesCatalog.Nodes[0].BackColor = Color.White;

            if (treeViewTablesCatalog.Nodes[0] == treeViewTablesCatalog.SelectedNode)
                return;

            var cntrl = ucrlTablesField.FindControlByName(treeViewTablesCatalog.SelectedNode.Text, ControlType.UserControl);
            var table = (TableComponent)cntrl;

            MarkTable(table);
        }

        private void MarkTable(TableComponent table)
        {
            foreach (var n in treeViewTablesCatalog.Nodes[0].Nodes)
                ((TreeNode)n).BackColor = Color.White;

            treeViewTablesCatalog.SelectedNode.BackColor = SystemColors.Highlight;

            if (ActiveTable != null)
                ActiveTable.BackColor = SystemColors.ControlLight;

            table.BackColor = Color.FromArgb(135, 206, 250);
            table.BringToFront();

            ActiveTable = table;
        }
    }
}
