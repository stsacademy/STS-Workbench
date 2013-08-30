﻿using System;
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
using STS.Workbench.Helpers;

namespace STS.Workbench
{
    public partial class DiagramPreview : UserControl
    {
        private int PageCapacity { get { return int.Parse(cmbxPageCount.Text); } }
        private object[] NextKey = null;
        private object[] PreviousKey = null;

        private int TableDistanceX = 180;

        private Dictionary<string, TableComponent> tables = new Dictionary<string, TableComponent>();

        private List<KeyValuePair<RowOperation, DataGridViewRow>> ModifyedRows = new List<KeyValuePair<RowOperation, DataGridViewRow>>();
        private List<DataGridViewRow> removedRows = new List<DataGridViewRow>();

        public readonly IConnection DbConnection;

        public TableComponent ActiveTable { get; private set; }
        public ITable OpenedTable { get; private set; }

        public DiagramPreview(IConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection");

            DbConnection = dbConnection;

            InitializeComponent();

            treeViewTablesCatalog.Nodes[0].Text = dbConnection.Name;
            splitContainer4.Panel1Collapsed = true;
            cmbxPageCount.Text = "5";

            PreviewScheme();
        }

        private void PreviewScheme()
        {
            Point PreviousTableLocation = new Point(15, 15);
            treeViewTablesCatalog.Nodes[0].Nodes.Clear();

            foreach (var table in tables)
                RemoveTable(table.Value);

            foreach (var table in DbConnection.GetSchema())
            {
                TableComponent tableComponent = new TableComponent(table.TableName, table.KeyTypes, table.RecordTypes);
                tableComponent.Name = table.TableName;
                tableComponent.Location = PreviousTableLocation;
                PreviousTableLocation = new Point(PreviousTableLocation.X + TableDistanceX, PreviousTableLocation.Y);
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
                //GetTableComponent
                Control control = ((Control)sender).Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent.Parent;
                if (control.GetType() == typeof(TableComponent))
                {
                    control.Left += e.X - MousePoint.X;
                    control.Top += e.Y - MousePoint.Y;

                    control.Left = control.Left < 0 ? control.Left = 0 : control.Left;
                    control.Top = control.Top < 0 ? control.Top = 0 : control.Top;
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
                cntrlTablesField.Cursor = new Cursor(global::STS.Workbench.Properties.Resources.table.GetHicon());
                IsPlacing = true;
            }
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            if (ActiveTable != null)
                RemoveTable(ActiveTable);

            DbConnection.RemoveTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);
        }

        private void btnCancelTable_Click(object sender, EventArgs e)
        {
            IsPlacing = false;
            splitContainer4.Panel1Collapsed = true;
            cntrlTablesField.Cursor = Cursors.Default;
        }

        private void AddTable(TableComponent table)
        {
            tables.Add(table.TableName, table);
            cntrlTablesField.Controls.Add(table);
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
            cntrlTablesField.Controls.Remove(table);
            tables.Remove(table.TableName);
            treeViewTablesCatalog.Nodes[0].Nodes.RemoveByKey(table.TableName);

            OpenedTable = null;
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
                table.Location = cntrlTablesField.PointToClient(MousePosition);

                AddTable(table);

                cntrlTablesField.Cursor = Cursors.Default;
                splitContainer4.Panel1Collapsed = true;
                IsPlacing = false;
            }
        }

        #region Table Select/Open

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
            ModifyedRows.Clear();
            var table = DbConnection.OpenTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);
            OpenedTable = table;
            VisualizeData(table, null, null);
        }

        private void treeViewTablesCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewTablesCatalog.Nodes[0].BackColor = Color.White;

            if (treeViewTablesCatalog.Nodes[0] == treeViewTablesCatalog.SelectedNode)
                return;

            var cntrl = cntrlTablesField.FindControlByName(treeViewTablesCatalog.SelectedNode.Text, ControlType.UserControl);
            var table = (TableComponent)cntrl;

            MarkTable(table);
        }

        private void treeViewTablesCatalog_DoubleClick(object sender, EventArgs e)
        {
            ModifyedRows.Clear();
            var table = DbConnection.OpenTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);
            OpenedTable = table;
            VisualizeData(table, null, null);
        }

        #endregion

        private void VisualizeData(ITable table, object[] fromKey, object[] toKey)
        {
            grdViewTableRecords.Rows.Clear();
            grdViewTableRecords.Columns.Clear();

            int keyTypesLen = table.KeyTypes.Length;
            int recTypesLen = table.RecordTypes.Length;

            grdViewTableRecords.ColumnCount = table.KeyTypes.Length + table.RecordTypes.Length;

            List<string> keyTypes = new List<string>();
            foreach (var keyType in table.KeyTypes)
                keyTypes.Add("(key) " + keyType);

            List<string> recTypes = new List<string>();
            foreach (var recType in table.RecordTypes)
                keyTypes.Add("(record) " + recType);

            var typesRow = keyTypes.Concat(recTypes);
            grdViewTableRecords.Rows.Add(typesRow.ToArray());
            grdViewTableRecords.Rows[0].ReadOnly = true;
            foreach (var cell in grdViewTableRecords.Rows[0].Cells)
                ((DataGridViewCell)cell).Style.BackColor = Color.LightBlue;

            object[] LastKey = null;
            foreach (var kv in table.Read(fromKey, null).Take(PageCapacity))
            {
                LastKey = kv.Key;
                List<object> list = new List<object>();
                list.AddRange(kv.Key);
                list.AddRange(kv.Value);

                grdViewTableRecords.Rows.Add(list.ToArray());
            }

            foreach (var kv in table.Read(fromKey, null).Take(1))
                PreviousKey = kv.Key;

            if (PreviousKey != null)
            {
                for (int i = 0; i < PageCapacity; i++)
                {
                    var before = table.FindBefore(PreviousKey);
                    PreviousKey = before.HasValue ? before.Value.Key : null;

                    if (!before.HasValue)
                        break;
                }
            }
            if (LastKey != null)
            {
                var after = table.FindAfter(LastKey);
                NextKey = after.HasValue ? after.Value.Key : null;
            }

            btnNextPage.Enabled = NextKey != null;
            btnPreviousPage.Enabled = PreviousKey != null;
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
            cntrlTablesField.ScrollControlIntoView(table);

            ActiveTable = table;
        }

        private void grdViewTableRecords_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Insert, grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 2]));
        }

        private void btnSaveRow_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            int keyCount = OpenedTable.KeyTypes.Length;
            int recCount = OpenedTable.RecordTypes.Length;

            foreach (var modfiyRow in ModifyedRows)
            {
                var kv = GetRowKeyValue(modfiyRow.Value, OpenedTable.KeyTypes.Length, OpenedTable.KeyTypes.Length);

                try
                {
                    if (modfiyRow.Key == RowOperation.Insert)
                        OpenedTable.Insert(kv.Key, kv.Value);
                    else if (modfiyRow.Key == RowOperation.Delete)
                        OpenedTable.Delete(kv.Key);
                }
                catch { }

                OpenedTable.Save();
            }

            ModifyedRows.Clear();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            ModifyedRows.Clear();
            VisualizeData(OpenedTable, null, null);
        }

        #region Export/Import

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Csv ';'separated (*.csv)|*.csv|Epf ',' separated (*.epf)|*.epf|Txt ',' separated (*.txt)|*.txt|Txt 'Tab' separated (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileType = (FileType)dialog.FilterIndex;
                FileImporter importer = new FileImporter(dialog.FileName, fileType);

                foreach (var kv in importer.Read(OpenedTable.KeyTypes.Length, OpenedTable.RecordTypes.Length))
                {
                    try
                    {
                        OpenedTable.Insert(kv.Key, kv.Value);
                    }
                    catch { }
                }

                OpenedTable.Save();
                VisualizeData(OpenedTable, null, null);
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = OpenedTable.TableName;
            dialog.Filter = "Csv ';'separated (*.csv)|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileExporter exporter = new FileExporter(dialog.FileName);
                exporter.Export(OpenedTable.Read());
            }
        }

        #endregion

        private void btnClearErrors_Click(object sender, EventArgs e)
        {
            tbxErrors.Clear();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            foreach (var row in grdViewTableRecords.SelectedRows)
            {
                //Not first(header) or last(empty) row.
                if ((DataGridViewRow)row != grdViewTableRecords.Rows[0] && (DataGridViewRow)row != grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 1])
                {
                    ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Delete, (DataGridViewRow)row));
                    grdViewTableRecords.Rows.Remove((DataGridViewRow)row);
                }
            }
        }

        private DataGridViewRow changedRow;
        private DataGridViewRow oldChangedRow;
        private void grdViewTableRecords_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdViewTableRecords.SelectedRows.Count > 0 && grdViewTableRecords.SelectedRows[0] != grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 1])
            {
                ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Delete, oldChangedRow));
                ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Insert, changedRow));
            }
        }

        private void grdViewTableRecords_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            changedRow = (DataGridViewRow)grdViewTableRecords.SelectedRows[0];
            oldChangedRow = new DataGridViewRow();
            {
                oldChangedRow.CreateCells(grdViewTableRecords);
                for (int i = 0; i < changedRow.Cells.Count; i++)
                    oldChangedRow.Cells[i].Value = changedRow.Cells[i].Value;
            }
        }

        private KeyValuePair<object[], object[]> GetRowKeyValue(DataGridViewRow row, int keyCount, int recCount)
        {
            object[] key = new object[keyCount];
            object[] rec = new object[recCount];

            for (int i = 0; i < keyCount; i++)
                key[i] = row.Cells[i].Value;

            for (int i = keyCount; i < keyCount + recCount; i++)
                rec[i - keyCount] = row.Cells[i].Value;

            return new KeyValuePair<object[], object[]>(key, rec);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            DbConnection.Commit();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, NextKey, null);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, PreviousKey, null);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, null, null);
        }

        private void cmbxPageCount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, null, null);
        }
    }
}