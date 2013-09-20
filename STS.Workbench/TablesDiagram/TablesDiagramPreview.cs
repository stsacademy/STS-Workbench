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

        public Dictionary<string, TableComponent> Tables { get { return tables; } }

        public TablesDiagramPreview(IConnection dbConnection)
        {
            if (dbConnection == null)
                throw new ArgumentNullException("dbConnection == null");

            DbConnection = dbConnection;

            InitializeComponent();

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

        #region Table Move & Resize

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

        private void table_MouseMove(object sender, MouseEventArgs e)
        {
            if (ActiveTableComponent != null && ActiveTableComponent.IsResizing)
            {
                int bottomPos = ActiveTableComponent.Top + ActiveTableComponent.Height;
                int rigthPos = ActiveTableComponent.Left + ActiveTableComponent.Width;

                ActiveTableComponent.UserResize(cntrlTablesField, bottomPos, rigthPos);
            }
            else if (IsMoving && e.Button == MouseButtons.Left)
            {
                var table = (TableComponent)sender;

                table.Left += e.X - MousePoint.X;
                table.Top += e.Y - MousePoint.Y;

                //prevent table to leave field bounds
                table.Left = table.Left < 0 ? 2 : table.Left;
                table.Top = table.Top < 0 ? 2 : table.Top;
                table.Left = table.Right > cntrlTablesField.mainField.Width ? cntrlTablesField.mainField.Width - table.Width : table.Left;
                table.Top = table.Bottom > cntrlTablesField.mainField.Height ? cntrlTablesField.mainField.Height - table.Height : table.Top;

                cntrlTablesField.ScrollControlIntoView(table);
                cntrlTablesField.Refresh();
            }
        }

        #endregion

        private void btnPlaceTable_Click(object sender, EventArgs e)
        {
            cntrlTablesField.Cursor = IsPlacing ? Cursors.Default : new Cursor(global::STS.Workbench.Properties.Resources.place_tableTansperent.GetHicon());
            IsPlacing = !IsPlacing;
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            if (ActiveTableComponent == null)
                return;

            if (MessageBox.Show(string.Format("Do you want to delete table {0}?", ActiveTableComponent.Name), "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void AddTable(TableComponent table)
        {
            tables.Add(table.TableName, table);
            cntrlTablesField.Add(table);
            treeViewTablesCatalog.Nodes[0].Nodes.Add(table.TableName, table.TableName);
            treeViewTablesCatalog.ExpandAll();

            //set events
            table.MouseUp += OnMouseUp;
            table.MouseDown += OnMouseDown;
            table.MouseMove += table_MouseMove;

            table.Click += table_Click;
            table.DoubleClick += table_DoubleClick;

            ShowMessage(string.Format("Placed table '{0}'", table.TableName));
        }

        private void RemoveTable(TableComponent table)
        {
            DbConnection.RemoveTable(ActiveTableComponent.Name, ActiveTableComponent.KeyTypes, ActiveTableComponent.RecordTypes);
            tables.Remove(table.TableName);
            treeViewTablesCatalog.Nodes[0].Nodes.RemoveByKey(table.TableName);
            cntrlTablesField.Controls.Remove(table);

            OpenedTable = null;
            ActiveTableComponent = null;
        }

        private void ucrlTablesField_Click(object sender, EventArgs e)
        {
            if (IsPlacing)
            {
                var selectedPosition = Cursor.Position;

                OpenTableWizard openTableDialog = new OpenTableWizard(this);
                openTableDialog.Location = PointToClient(selectedPosition);

                if (openTableDialog.ShowDialog() == DialogResult.OK)
                {
                    TableComponent table = new TableComponent(openTableDialog.TableName, openTableDialog.KeyTypes, openTableDialog.RecordTypes);
                    table.Location = cntrlTablesField.PointToClient(selectedPosition);

                    AddTable(table);
                }

                cntrlTablesField.Cursor = Cursors.Default;
                IsPlacing = false;
            }
        }

        #region Table Mark/Open

        private void table_Click(object sender, EventArgs e)
        {
            var table = (TableComponent)sender;

            var node = treeViewTablesCatalog.Nodes[0].Nodes.Find(table.TableName, true)[0];
            treeViewTablesCatalog.SelectedNode = node;

            MarkTable(table);
        }

        private void treeViewTablesCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewTablesCatalog.Nodes[0] == treeViewTablesCatalog.SelectedNode)
                return;

            TableComponent table;
            tables.TryGetValue(treeViewTablesCatalog.SelectedNode.Text, out table);

            MarkTable(table);
        }

        private void table_DoubleClick(object sender, EventArgs e)
        {
            OpenTable();
        }

        private void treeViewTablesCatalog_DoubleClick(object sender, EventArgs e)
        {
            OpenTable();
        }

        private void OpenTable()
        {
            try
            {
                ModifyedRows.Clear();
                var table = DbConnection.OpenTable(ActiveTableComponent.Name, ActiveTableComponent.KeyTypes, ActiveTableComponent.RecordTypes);
                OpenedTable = table;
                VisualizeData(table, null, null);

                ShowMessage(string.Format(@"Opened table '{0}'", table.TableName));
            }
            catch (Exception e)
            {
                FormExtensions.ShowError(e.Message);
            }
        }

        #endregion

        private void VisualizeData(ITable table, object[] fromKey, object[] toKey)
        {
            try
            {
                grdViewTableRecords.SetHeader(table);

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

        private void MarkTable(TableComponent table)
        {
            if (ActiveTableComponent != null)
                ActiveTableComponent.DisableResizers();

            table.EnableResizers();

            treeViewTablesCatalog.Nodes[0].SetChildBackColor(Color.White);
            treeViewTablesCatalog.SelectedNode.BackColor = SystemColors.Highlight;

            table.BringToFront();
            cntrlTablesField.ScrollControlIntoView(table);

            ActiveTableComponent = table;
            pgrdTableInfo.SelectedObject = ActiveTableComponent;
            ShowMessage(string.Format(@"Selected table '{0}'", table.Name));
        }

        private void grdViewTableRecords_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ModifyedRows.Add(new KeyValuePair<RowOperation, DataGridViewRow>(RowOperation.Insert, grdViewTableRecords.Rows[grdViewTableRecords.Rows.Count - 2]));
        }

        private void btnSaveRowChanges_Click(object sender, EventArgs e)
        {
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
                grdViewTableRecords.SetHeader(OpenedTable);

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
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (loadingForm == null)
                {
                    loadingForm = new LoadingForm();
                    loadingForm.Show();
                }
                else //(loadingForm != null)
                {
                    loadingForm.SetPercents(FileUtils.Percents);

                    if (loadingForm.StopClicked)
                    {
                        FileUtils.Stop();
                        Worker.Join();
                        loadingForm.Close();
                        loadingForm = null;
                    }
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
            spltCntTablesData.Panel2Collapsed = true;
            pgrdTableInfo.SelectedObject = null;
        }

        private void btnLoadDiagram_Click(object sender, EventArgs e)
        {
            cntrlTablesField.VerticalScroll.Value = 0;
            cntrlTablesField.HorizontalScroll.Value = 0;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dialog.FileName, FileMode.Open))
                {
                    BinaryReader reader = new BinaryReader(stream);
                    int count = reader.ReadInt32();

                    for (int i = 0; i < count; i++)
                    {
                        string name = reader.ReadString();
                        bool expanded = reader.ReadBoolean();
                        var mesures = TableComponent.DeserializeMesures(reader);

                        TableComponent table;
                        if (Tables.TryGetValue(name, out table))
                        {
                            if (expanded)
                                table.Expand();
                            else
                                table.Collapse();

                            table.Location = mesures.Key;
                            table.Size = mesures.Value;
                        }
                    }
                }
            }
        }

        private void btnSaveTableDiagram_Click(object sender, EventArgs e)
        {
            cntrlTablesField.VerticalScroll.Value = 0;
            cntrlTablesField.HorizontalScroll.Value = 0;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "diagram (*.dgr)|*.dgr";
            dialog.FileName = "schema";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create))
                {
                    BinaryWriter writer = new BinaryWriter(stream);

                    writer.Write(Tables.Count);
                    foreach (var item in Tables)
                    {
                        writer.Write(item.Key);
                        writer.Write(item.Value.Expanded);
                        item.Value.SerializeMesures(writer);
                    }
                }
            }
        }

        private void btnExpandTables_Click(object sender, EventArgs e)
        {
            foreach (var item in Tables)
                item.Value.Expand();
        }

        private void btnCollapseTablse_Click(object sender, EventArgs e)
        {
            foreach (var item in Tables)
                item.Value.Collapse();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            cntrlTablesField.Scale(new SizeF(1.1f, 1.1f));
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            cntrlTablesField.Scale(new SizeF(0.9f, 0.9f));
        }

        private void ShowMessage(string text)
        {
            lblInfo.Text = text;
        }
    }
}