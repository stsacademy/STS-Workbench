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
using STS.Workbench.Helpers;
using System.Threading;
using STS.Workbench.TablesDiagram.DiagramPreviewComponents;
using STS.Workbench.TablesDiagram.Helpers;

namespace STS.Workbench
{
    public partial class DiagramPreview : UserControl
    {
        private Thread Worker = new Thread(() => Console.Write(""));
        private IProgressable WorkingInstance = null;
        private LoadingForm loadingForm = new LoadingForm();

        private int PageCapacity { get { return int.Parse(cmbxPageCount.Text); } }
        private object[] NextKey = null;
        private object[] CurrentKey = null;
        private object[] PreviousKey = null;

        private int TableDistanceX = 180;
        private Dictionary<string, TableComponent> tables = new Dictionary<string, TableComponent>();

        private List<KeyValuePair<RowOperation, DataGridViewRow>> ModifyedRows = new List<KeyValuePair<RowOperation, DataGridViewRow>>();

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
            DbConnection.RemoveTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);

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

        private void treeViewTablesCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeViewTablesCatalog.Nodes[0].BackColor = Color.White;

            if (treeViewTablesCatalog.Nodes[0] == treeViewTablesCatalog.SelectedNode)
                return;

            var cntrl = cntrlTablesField.FindControlByName(treeViewTablesCatalog.SelectedNode.Text);
            var table = (TableComponent)cntrl;

            MarkTable(table);
        }

        private void table_DoubleClick(object sender, EventArgs e)
        {
            ModifyedRows.Clear();
            var table = DbConnection.OpenTable(ActiveTable.Name, ActiveTable.KeyTypes, ActiveTable.RecordTypes);
            OpenedTable = table;

            VisualizeData(table, null, null);
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
            grdViewTableRecords.ColumnCount = table.KeyTypes.Length + table.RecordTypes.Length;

            List<string> keyTypes = new List<string>(table.KeyTypes.Select(x => x.ToString()));
            List<string> recTypes = new List<string>(table.RecordTypes.Select(x => x.ToString()));
            List<string> typesRow = new List<string>(keyTypes.Concat(recTypes));

            for (int i = 0; i < typesRow.Count; i++)
            {
                typesRow[i] = i >= table.KeyTypes.Length ? "(record) " + typesRow[i] : "(key) " + typesRow[i];
                grdViewTableRecords.Columns[i].HeaderText = typesRow[i];
                grdViewTableRecords.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            NextKey = null;
            CurrentKey = null;
            object[] lastKey = null;
            foreach (var kv in table.Read(fromKey, null).Take(PageCapacity))
            {
                grdViewTableRecords.Rows.Add(kv.Key.Concat(kv.Value).ToArray());
                lastKey = kv.Key;
            }

            foreach (var kv in table.Read(fromKey, null).Take(1))
                CurrentKey = kv.Key;

            PreviousKey = CurrentKey;
            if (PreviousKey != null)
            {
                for (int i = 0; i < PageCapacity; i++)
                {
                    var before = table.FindBefore(PreviousKey);
                    if (!before.HasValue)
                        break;

                    PreviousKey = before.Value.Key;
                }
            }

            if (lastKey != null)
            {
                var after = table.FindAfter(lastKey);
                NextKey = after.HasValue ? after.Value.Key : null;
            }

            btnNextPage.Enabled = NextKey != null;
            btnPreviousPage.Enabled = PreviousKey != CurrentKey;
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

            foreach (var modfiyRow in ModifyedRows)
            {
                var kv = modfiyRow.Value.GetKeyValue(OpenedTable.KeyTypes.Length, OpenedTable.KeyTypes.Length);

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
                Worker = new Thread(() =>
                    {
                        foreach (var kv in FileUtils.Import(dialog.FileName, fileType, OpenedTable.KeyTypes.Length, OpenedTable.RecordTypes.Length))
                        {
                            try
                            {
                                OpenedTable.Insert(kv.Key, kv.Value);
                            }
                            catch { }
                        };

                        OpenedTable.Save();
                    }
                );
                Worker.Start();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (OpenedTable == null)
                return;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = OpenedTable.TableName;
            dialog.Filter = "Csv ';'separated (*.csv)|*.csv|Epf ',' separated (*.epf)|*.epf|Txt ',' separated (*.txt)|*.txt|Txt 'Tab' separated (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileType = (FileType)dialog.FilterIndex;
                Worker = new Thread(() => FileUtils.Export(OpenedTable.Read(), dialog.FileName, fileType, OpenedTable.Count));
                Worker.Start();
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
                //Not last(empty) row.
                if ((DataGridViewRow)row != grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 1])
                {
                    ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Delete, (DataGridViewRow)row));
                    grdViewTableRecords.Rows.Remove((DataGridViewRow)row);
                }
            }
        }

        private DataGridViewRow clickedRow;
        private DataGridViewRow oldChangedRow;
        private void grdViewTableRecords_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (grdViewTableRecords.SelectedRows.Count > 0 && grdViewTableRecords.SelectedRows[0] != grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 1])
            {
                ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Delete, oldChangedRow));
                ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Insert, clickedRow));
            }
        }

        private void grdViewTableRecords_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            clickedRow = (DataGridViewRow)grdViewTableRecords.SelectedRows[0];
            oldChangedRow = new DataGridViewRow();

            oldChangedRow.CreateCells(grdViewTableRecords);
            for (int i = 0; i < clickedRow.Cells.Count; i++)
                oldChangedRow.Cells[i].Value = clickedRow.Cells[i].Value;
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
                VisualizeData(OpenedTable, CurrentKey, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = !Worker.IsAlive;
            if (Worker.IsAlive)
            {
                loadingForm.Show();
                loadingForm.progressBar1.Value = FileUtils.Percents;

                if (loadingForm.StopClicked)
                {
                    Thread thread = Worker;
                    FileUtils.Stop();
                    thread.Join(2000);
                }
            }
            else
            {
                loadingForm.Hide();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, CurrentKey, null);
        }
    }
}