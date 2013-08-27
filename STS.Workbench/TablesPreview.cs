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
        private Point LastTableLocation = new Point(40, 40);
        private Dictionary<string, TableComponent> tables = new Dictionary<string, TableComponent>();

        private List<DataGridViewRow> addedRows = new List<DataGridViewRow>();
        private List<DataGridViewRow> removedRows = new List<DataGridViewRow>();

        public readonly IConnection DbConnection;

        public TableComponent ActiveTable { get; private set; }
        public ITable OpenedTable { get; private set; }

        public TablesPreview(IConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection");

            DbConnection = dbConnection;

            InitializeComponent();
            splitContainer4.Panel1Collapsed = true;

            PreviewScheme();
        }

        private void PreviewScheme()
        {
            foreach (var table in DbConnection.GetSchema())
            {
                TableComponent tableComponent = new TableComponent(table.TableName, table.KeyTypes, table.RecordTypes);
                tableComponent.Location = LastTableLocation;
                LastTableLocation = new Point(LastTableLocation.X + 200, LastTableLocation.Y);
                AddTable(tableComponent);
            }
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
            var table = DbConnection.OpenTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);
            OpenedTable = table;
            VisualizeData(table);
        }

        private void VisualizeData(ITable table)
        {
            grdViewTableRecords.Rows.Clear();
            grdViewTableRecords.Columns.Clear();

            int keyTypesLen = table.KeyTypes.Length;
            int recTypesLen = table.RecordTypes.Length;

            grdViewTableRecords.ColumnCount = table.KeyTypes.Length + table.RecordTypes.Length;

            List<object> types = new List<object>();
            List<string> keyTypes = new List<string>();
            List<string> recTypes = new List<string>();

            foreach (var keyType in table.KeyTypes)
                keyTypes.Add("(key) " + keyType);

            foreach (var recType in table.RecordTypes)
                keyTypes.Add("(record) " + recType);

            types.AddRange(keyTypes);
            types.AddRange(recTypes);
            grdViewTableRecords.Rows.Add(types.ToArray());
            grdViewTableRecords.Rows[0].ReadOnly = true;
            foreach (var cell in grdViewTableRecords.Rows[0].Cells)
                ((DataGridViewCell)cell).Style.BackColor = Color.LightBlue;

            foreach (var kv in table.Read())
            {
                List<object> list = new List<object>();
                list.AddRange(kv.Key);
                list.AddRange(kv.Value);

                grdViewTableRecords.Rows.Add(list.ToArray());
            }
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

        private void grdViewTableRecords_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            addedRows.Add(grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 1]);
        }

        private void btnSaveRow_Click(object sender, EventArgs e)
        {
            int keyCount = OpenedTable.KeyTypes.Length;
            int recCount = OpenedTable.RecordTypes.Length;

            object[] key = new object[keyCount];
            object[] rec = new object[recCount];

            //TODO objectString to IDAta transofmer
            foreach (var row in addedRows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    for (int j = 0; j < keyCount; j++)
                        key[j] = row.Cells[j].Value;

                    int recCounter = 0;
                    for (int j = keyCount; j < keyCount + recCount; j++)
                        rec[recCounter++] = row.Cells[j].Value;

                    OpenedTable.Insert(key, rec);
                }
            }
        }
    }
}
