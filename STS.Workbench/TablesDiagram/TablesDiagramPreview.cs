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
using System.IO;
using STS.Workbench.TablesDiagram.TablesDiagramComponents;

namespace STS.Workbench
{
    public partial class TablesDiagramPreview : UserControl
    {
        private LoadingForm loadingForm = null;
        private Thread Worker = new Thread(() => { });

        private int PageCapacity { get { return int.Parse(cmbxPageCount.Text); } }

        private object[] NextKey = null;
        private object[] CurrentKey = null;
        private object[] PreviousKey = null;

        private Dictionary<string, TableComponent> tables = new Dictionary<string, TableComponent>();

        private List<KeyValuePair<RowOperation, DataGridViewRow>> ModifyedRows = new List<KeyValuePair<RowOperation, DataGridViewRow>>();

        public readonly IConnection DbConnection;

        public TableComponent ActiveTableComponent { get; private set; }
        public ITable OpenedTable { get; private set; }

        public Dictionary<string, TableComponent> TablesMap { get { return tables; } }

        public TablesDiagramPreview(IConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection == null");

            DbConnection = dbConnection;

            InitializeComponent();

            selectorTool = new SelectorTool(tablesField.mainField);
            spltCntTablesData.Panel2Collapsed = true;
            treeViewTablesCatalog.Nodes[0].Text = dbConnection.Name;
            cmbxPageCount.Text = "5";

            PreviewScheme(190);
        }

        private void PreviewScheme(int tableDisatance)
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
                PreviousTableLocation = new Point(PreviousTableLocation.X + tableDisatance, PreviousTableLocation.Y);
                AddTable(tableComponent);
            }
        }

        #region Table - move, resize and selection

        private SelectorTool selectorTool;
        private List<TableComponent> selectedTables = new List<TableComponent>();
        private Point SelectedMousePoint;
        private bool IsMoving = false;
        private bool IsPlacing = false;
        private bool IsSelecting = false;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SelectedMousePoint = e.Location;

                if (sender.GetType() == typeof(TableComponent))
                {
                    IsMoving = true;
                    if (!selectedTables.Contains((TableComponent)sender))
                    {
                        UnSelectTables();
                        SelectTable((TableComponent)sender);
                    }

                }
                else if (sender.GetType() == typeof(FieldControl))
                {
                    IsSelecting = true;
                    selectorTool.ClearLastSelection();
                }
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (IsSelecting)
            {
                UnSelectTables();
                SelectTables(selectorTool.GetSelectedItems(TablesMap.Values));
                IsSelecting = false;
            }

            IsMoving = false;
            tablesField.Refresh();
        }

        private void On_MouseMove(object sender, MouseEventArgs e)
        {
            //Do resize
            if (ActiveTableComponent != null && ActiveTableComponent.IsResizing)
            {
                int bottomPos = ActiveTableComponent.Top + ActiveTableComponent.Height;
                int rigthPos = ActiveTableComponent.Left + ActiveTableComponent.Width;

                ActiveTableComponent.UserResize(tablesField.mainField, bottomPos, rigthPos, tablesField.VerticalScroll.Value, tablesField.HorizontalScroll.Value);
                return;
            }

            //Do move
            if (IsMoving)
            {
                bool canMove = selectedTables.TrueForAll(x => !x.IsLeavingOwnerBounds(tablesField.mainField, SelectedMousePoint, e));
                if (canMove)
                {
                    foreach (var table in selectedTables)
                    {
                        table.Left += e.X - SelectedMousePoint.X;
                        table.Top += e.Y - SelectedMousePoint.Y;
                    }
                }
                return;
            }

            //Do select
            if (IsSelecting)
                selectorTool.DrawRectangle(new Pen(Color.Black), SelectedMousePoint, e.Location);
        }

        private void SelectTables(List<Control> tables)
        {
            foreach (var table in tables)
                SelectTable((TableComponent)table);

            if (tables.Count == 1)
                ((TableComponent)tables[0]).EnableResizers();
            else if (tables.Count > 1)
                ShowMessage(string.Format(@"Selected tables '{0}'", string.Join(", ", new List<string>(tables.Select(x => ((TableComponent)x).Name)))));
        }

        private void UnSelectTables()
        {
            foreach (var table in selectedTables)
                table.BackColor = Color.Transparent;

            selectedTables.Clear();
        }

        private void SelectTable(TableComponent table)
        {
            if (ActiveTableComponent != null)
                ActiveTableComponent.DisableResizers();

            table.BackColor = Color.FromArgb(235, 195, 140);
            table.CurrentColor = Color.FromArgb(235, 195, 140);
            selectedTables.Add(table);

            treeViewTablesCatalog.Nodes[0].SetChildBackColor(Color.White);
            treeViewTablesCatalog.Nodes[0].Nodes.Find(table.TableName, true)[0].BackColor = SystemColors.Highlight;

            table.BringToFront();
            tablesField.ScrollControlIntoView(table);

            ActiveTableComponent = table;
            ShowMessage(string.Format(@"Selected table '{0}'", table.Name));
        }

        #endregion

        private void btnPlaceTable_Click(object sender, EventArgs e)
        {
            tablesField.Cursor = IsPlacing ? Cursors.Default : new Cursor(global::STS.Workbench.Properties.Resources.place_tableTansperent.GetHicon());
            IsPlacing = !IsPlacing;
        }

        private void btnDeleteTables_Click(object sender, EventArgs e)
        {
            foreach (var table in selectedTables)
            {
                if (MessageBox.Show(string.Format("Do you want to delete table {0}?", table.Name), "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        RemoveTable(ActiveTableComponent);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddTable(TableComponent table)
        {
            tables.Add(table.TableName, table);
            tablesField.Add(table);
            treeViewTablesCatalog.Nodes[0].Nodes.Add(table.TableName, table.TableName);
            treeViewTablesCatalog.ExpandAll();

            //set events
            table.MouseUp += OnMouseUp;
            table.MouseDown += OnMouseDown;
            table.MouseMove += On_MouseMove;

            table.Click += table_Click;
            table.DoubleClick += table_DoubleClick;
            ShowMessage(string.Format("Placed table '{0}'", table.TableName));
        }

        private void RemoveTable(TableComponent table)
        {
            DbConnection.RemoveTable(ActiveTableComponent.Name, ActiveTableComponent.KeyTypes, ActiveTableComponent.RecordTypes);
            tables.Remove(table.TableName);
            treeViewTablesCatalog.Nodes[0].Nodes.RemoveByKey(table.TableName);
            tablesField.Controls.Remove(table);

            OpenedTable = null;
            ActiveTableComponent = null;
        }

        private void tablesField_Click(object sender, EventArgs e)
        {
            var selectedPosition = Cursor.Position;

            if (IsPlacing)
            {
                OpenTableWizard openTableDialog = new OpenTableWizard(this);
                openTableDialog.Location = PointToClient(selectedPosition);

                if (openTableDialog.ShowDialog() == DialogResult.OK)
                {
                    TableComponent table = new TableComponent(openTableDialog.TableName, openTableDialog.KeyTypes, openTableDialog.RecordTypes);
                    table.Location = tablesField.PointToClient(selectedPosition);

                    AddTable(table);
                }

                tablesField.Cursor = Cursors.Default;
                IsPlacing = false;
            }

            var mouseEvent = (MouseEventArgs)e;
            if (mouseEvent.Button == MouseButtons.Left)
                UnSelectTables();
            else
            {
                mStripTablesField.Items["expandToolStripMenuItem"].Enabled = selectedTables.Count > 0;
                mStripTablesField.Items["collapseToolStripMenuItem"].Enabled = selectedTables.Count > 0;
                mStripTablesField.Items["pasteToolStripMenuItem"].Enabled = TablesTransfer.HavePaste;
                var size = (ToolStripMenuItem)mStripTablesField.Items["sizeToolStripMenuItem"];
                size.DropDownItems["incrase2xToolStripMenuItem"].Enabled = tablesField.AllowIncrase;
                size.DropDownItems["decrase2xToolStripMenuItem"].Enabled = tablesField.AllowDecrase;

                mStripTablesField.Show(Cursor.Position);
            }
        }

        #region Table Mark/Open

        private void table_Click(object sender, EventArgs e)
        {
            var table = (TableComponent)sender;
            var mouseEventArgs = (MouseEventArgs)e;

            if (mouseEventArgs.Button == MouseButtons.Right)
            {
                mStripTables.Items["openToolStripMenuItem"].Enabled = OpenedTable == null || OpenedTable.TableName != table.TableName;
                mStripTables.Items["closeToolStripMenuItem"].Enabled = OpenedTable != null && OpenedTable.TableName == table.TableName;
                mStripTables.Items["pasteDataToolStripMenuItem"].Enabled = TablesTransfer.HavePaste;
                mStripTables.Show(Cursor.Position);
            }

            UnSelectTables();
            SelectTable(table);
        }

        private void treeViewTablesCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewTablesCatalog.Nodes[0] == treeViewTablesCatalog.SelectedNode)
                return;

            TableComponent table;
            tables.TryGetValue(treeViewTablesCatalog.SelectedNode.Text, out table);

            UnSelectTables();
            SelectTable(table);
        }

        private void table_DoubleClick(object sender, EventArgs e)
        {
            OpenTable((TableComponent)sender);
        }

        private void treeViewTablesCatalog_DoubleClick(object sender, EventArgs e)
        {
            OpenTable(ActiveTableComponent);
        }

        private void OpenTable(TableComponent table)
        {
            try
            {
                ModifyedRows.Clear();
                var openedTable = DbConnection.OpenTable(table.TableName, table.KeyTypes, table.RecordTypes);
                OpenedTable = openedTable;
                VisualizeData(openedTable, null, null);

                pgrdTableInfo.SelectedObject = openedTable;
                ShowMessage(string.Format(@"Opened table '{0}'", openedTable.TableName));
            }
            catch (Exception e)
            {
                FormExtensions.ShowError(e.Message);
            }
        }

        private void CloseOpenedTable()
        {
            OpenedTable = null;
            spltCntTablesData.Panel2Collapsed = true;
            pgrdTableInfo.SelectedObject = null;
        }

        #endregion

        private void VisualizeData(ITable table, object[] fromKey, object[] toKey)
        {
            try
            {
                grdViewTableRecords.SetTableHeader(table);

                object[] lastKey = null;
                foreach (var kv in table.Read(fromKey, null).Take(PageCapacity))
                {
                    grdViewTableRecords.Rows.Add(kv.Key.Concat(kv.Value).ToArray());
                    lastKey = kv.Key;
                }

                NextKey = table.Read(lastKey, null).Take(2).LastOrDefault().Key;
                CurrentKey = table.Read(fromKey, null).FirstOrDefault().Key;
                PreviousKey = OpenedTable.ReadReverse(CurrentKey, null).Take(PageCapacity + 1).LastOrDefault().Key;

                btnNextPage.Enabled = NextKey != null;
                btnPreviousPage.Enabled = CurrentKey != null && !object.Equals(PreviousKey[0], CurrentKey[0]);
                spltCntTablesData.Panel2Collapsed = false;
            }
            catch (Exception e)
            {
                FormExtensions.ShowError(e.Message);
            }
        }

        private void grdViewTableRecords_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Insert, grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 2]));
        }

        private void btnSaveRowChanges_Click(object sender, EventArgs e)
        {
            foreach (var modfiyRow in ModifyedRows)
            {
                var kv = modfiyRow.Value.GetKeyValue(OpenedTable.KeyTypes.Length, OpenedTable.RecordTypes.Length);

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
            ModifyedRows.Clear();
            VisualizeData(OpenedTable, CurrentKey, null);
        }

        #region Export/Import

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
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
                loadingForm = new LoadingForm();
                loadingForm.Show();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = OpenedTable.TableName;
            dialog.Filter = "Csv ';'separated (*.csv)|*.csv|Epf ',' separated (*.epf)|*.epf|Txt ',' separated (*.txt)|*.txt|Txt 'Tab' separated (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileType = (FileType)dialog.FilterIndex;
                Worker = new Thread(() => FileUtils.Export(OpenedTable.Read(), dialog.FileName, fileType));
                Worker.Start();
                loadingForm = new LoadingForm();
                loadingForm.Show();
            }
        }

        #endregion

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
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
            VisualizeData(OpenedTable, NextKey, null);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            VisualizeData(OpenedTable, PreviousKey, null);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            VisualizeData(OpenedTable, null, null);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            try
            {
                grdViewTableRecords.SetTableHeader(OpenedTable);

                foreach (var kv in OpenedTable.ReadReverse().Take(PageCapacity).Reverse())
                    grdViewTableRecords.Rows.Add(kv.Key.Concat(kv.Value).ToArray());

                CurrentKey = OpenedTable.ReadReverse().Take(PageCapacity).Reverse().FirstOrDefault().Key;
                PreviousKey = OpenedTable.ReadReverse(CurrentKey, null).Take(PageCapacity + 1).LastOrDefault().Key;

                btnNextPage.Enabled = false;
                btnPreviousPage.Enabled = PreviousKey != null;

                spltCntTablesData.Panel2Collapsed = false;
            }
            catch (Exception exc)
            {
                FormExtensions.ShowError(exc.Message);
            }
        }

        private void cmbxPageCount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OpenedTable != null)
                VisualizeData(OpenedTable, CurrentKey, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enabled = !Worker.IsAlive;

            if (Worker.IsAlive)
            {
                loadingForm.SetPercents(FileUtils.Percents);
                if (loadingForm.StopClicked)
                {
                    FileUtils.Stop();
                    Worker.Join();
                }
            }

            if (!Worker.IsAlive && loadingForm != null)
            {
                loadingForm.Close();
                loadingForm = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            VisualizeData(OpenedTable, CurrentKey, null);
        }

        private void btnSelectAllRows_Click(object sender, EventArgs e)
        {
            grdViewTableRecords.SelectAll();
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            DbConnection.Close();
        }

        private void btnHideData_Click(object sender, EventArgs e)
        {
            CloseOpenedTable();
        }

        private void btnLoadDiagram_Click(object sender, EventArgs e)
        {
            tablesField.ResetScrollBars();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(dialog.FileName, FileMode.Open)))
                {
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        TableComponent table;

                        var settings = TableComponent.DeserializeSettings(reader);
                        if (TablesMap.TryGetValue(settings.TableName, out table))
                            table.ApplySettings(settings);
                    }
                }
            }
        }

        private void btnSaveTableDiagram_Click(object sender, EventArgs e)
        {
            tablesField.ResetScrollBars();

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            dialog.FileName = "schema";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(dialog.FileName, FileMode.Create)))
                {
                    writer.Write(TablesMap.Count);
                    foreach (var table in TablesMap)
                        table.Value.SerializeSettings(writer);
                }
            }
        }

        private void btnCollapseTablse_Click(object sender, EventArgs e)
        {
            foreach (var item in TablesMap)
                item.Value.Collapse();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tablesField.Scale(new SizeF(1.1f, 1.1f));
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            tablesField.Scale(new SizeF(0.9f, 0.9f));
        }

        private void ShowMessage(string text)
        {
            lblInfo.Text = text;
        }

        #region Table menu strip

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTable(ActiveTableComponent);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOpenedTable();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = DbConnection.OpenTable(ActiveTableComponent.TableName, ActiveTableComponent.KeyTypes, ActiveTableComponent.RecordTypes);
            TablesTransfer.Copy(table);
        }

        private void pasteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = TablesTransfer.Paste()[0];
            var activeTable = DbConnection.OpenTable(ActiveTableComponent.TableName, ActiveTableComponent.KeyTypes, ActiveTableComponent.RecordTypes);

            try
            {
                foreach (var kv in table.Read())
                    activeTable.Insert(kv.Key, kv.Value);
            }
            catch (Exception exc)
            {
                FormExtensions.ShowError(exc.Message);
            }
        }

        private void editColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = ActiveTableComponent.BackGroundColor;
            if (dialog.ShowDialog() == DialogResult.OK)
                ActiveTableComponent.BackGroundColor = dialog.Color;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Cursor.Position.X + " " + Cursor.Position.Y);
            PropertyForm form = new PropertyForm(ActiveTableComponent);
            form.ShowDialog();
        }

        #endregion

        #region TableField menu strip

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tables = TablesTransfer.Paste();

            Point location = tablesField.PointToClient(Cursor.Position);
            foreach (var table in tables)
            {
                var component = new TableComponent(table.TableName, table.KeyTypes, table.RecordTypes);
                var newTable = DbConnection.OpenTable(table.TableName, table.KeyTypes, table.RecordTypes);
                try
                {
                    component.Location = location;
                    AddTable(component);
                    foreach (var kv in table.Read())
                        newTable.Insert(kv.Key, kv.Value);

                    location = location.X + component.Width + 20 > tablesField.Width ? new Point(20, location.Y + component.Height + 20) : location;
                    location = location.Y + component.Height + 20 > tablesField.Height ? new Point(20, 20) : location;
                    location = new Point(location.X + component.Width + 20, location.Y);
                }
                catch (Exception exc)
                {
                    FormExtensions.ShowError(exc.Message);
                }
            }
        }

        private void saveOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablesField.ResetScrollBars();

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            dialog.FileName = "schema";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter writer = new BinaryWriter(new FileStream(dialog.FileName, FileMode.Create)))
                {
                    writer.Write(TablesMap.Count);
                    foreach (var table in TablesMap)
                        table.Value.SerializeSettings(writer);
                }
            }
        }

        private void loadOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablesField.ResetScrollBars();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(dialog.FileName, FileMode.Open)))
                {
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        TableComponent table;

                        var settings = TableComponent.DeserializeSettings(reader);
                        if (TablesMap.TryGetValue(settings.TableName, out table))
                            table.ApplySettings(settings);
                    }
                }
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = (ToolStripMenuItem)sender;
            switch (control.Name)
            {
                case "defaultToolStripMenuItem":
                    tablesField.SetDefaultSize();
                    break;
                case "incrase2xToolStripMenuItem":
                    tablesField.IncraseSizeQuatter();
                    break;
                case "decrase2xToolStripMenuItem":
                    tablesField.DecraseSizeQuatter();
                    break;
                default:
                    break;
            }

            foreach (var table in TablesMap.Values)
            {
                if (table.Location.X + table.Width > tablesField.mainField.Width)
                    table.Location = new Point(40, 40);
            }
        }

        private void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var table in selectedTables)
                table.Expand();
        }

        private void collapseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var table in selectedTables)
                table.Collapse();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<ITable> tables = new List<ITable>(selectedTables.Select<TableComponent, ITable>((x) => { return DbConnection.OpenTable(x.TableName, x.KeyTypes, x.RecordTypes); }));
            TablesTransfer.Copy(tables.ToArray());
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectTables(new List<Control>(TablesMap.Values.Select(x => (Control)x)));
        }

        #endregion
    }
}