using System.Windows.Forms;
namespace STS.Workbench
{
    partial class TablesDiagramPreview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("myDb");
            this.grdViewTableRecords = new System.Windows.Forms.DataGridView();
            this.treeViewTablesCatalog = new System.Windows.Forms.TreeView();
            this.splitContainerTablesPreview = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblCatalogTree = new System.Windows.Forms.Label();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.lblSelectedTableInfo = new System.Windows.Forms.Label();
            this.pgrdTableInfo = new System.Windows.Forms.PropertyGrid();
            this.spltCntTablesData = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDiagramHeader = new System.Windows.Forms.Label();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.btnPlaceTable = new System.Windows.Forms.Button();
            this.btnDeleteTables = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnHideData = new System.Windows.Forms.Button();
            this.btnSelectAllRows = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblImportExport = new System.Windows.Forms.Label();
            this.lblEditRows = new System.Windows.Forms.Label();
            this.lblChanges = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDeleteRows = new System.Windows.Forms.Button();
            this.btnSaveRowChanges = new System.Windows.Forms.Button();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.cmbxPageCount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mStripTables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripTablesField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrase2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrase2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mStripCatalogDb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripCatalogTables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesField = new STS.Workbench.TablesDiagram.DiagramPreviewComponents.FieldControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTableRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTablesPreview)).BeginInit();
            this.splitContainerTablesPreview.Panel1.SuspendLayout();
            this.splitContainerTablesPreview.Panel2.SuspendLayout();
            this.splitContainerTablesPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltCntTablesData)).BeginInit();
            this.spltCntTablesData.Panel1.SuspendLayout();
            this.spltCntTablesData.Panel2.SuspendLayout();
            this.spltCntTablesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.mStripTables.SuspendLayout();
            this.mStripTablesField.SuspendLayout();
            this.mStripCatalogDb.SuspendLayout();
            this.mStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewTableRecords
            // 
            this.grdViewTableRecords.AllowUserToDeleteRows = false;
            this.grdViewTableRecords.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdViewTableRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewTableRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewTableRecords.Location = new System.Drawing.Point(0, 0);
            this.grdViewTableRecords.Name = "grdViewTableRecords";
            this.grdViewTableRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewTableRecords.Size = new System.Drawing.Size(1082, 151);
            this.grdViewTableRecords.TabIndex = 3;
            this.grdViewTableRecords.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewTableRecords_CellMouseClick);
            this.grdViewTableRecords.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewTableRecords_CellValueChanged);
            this.grdViewTableRecords.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdViewTableRecords_UserAddedRow);
            // 
            // treeViewTablesCatalog
            // 
            this.treeViewTablesCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTablesCatalog.Location = new System.Drawing.Point(3, 3);
            this.treeViewTablesCatalog.Name = "treeViewTablesCatalog";
            treeNode3.Name = "trvCatalogTree";
            treeNode3.Text = "myDb";
            this.treeViewTablesCatalog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeViewTablesCatalog.Size = new System.Drawing.Size(194, 173);
            this.treeViewTablesCatalog.TabIndex = 4;
            this.treeViewTablesCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTablesCatalog_AfterSelect);
            this.treeViewTablesCatalog.DoubleClick += new System.EventHandler(this.treeViewTablesCatalog_DoubleClick);
            // 
            // splitContainerTablesPreview
            // 
            this.splitContainerTablesPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTablesPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTablesPreview.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTablesPreview.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTablesPreview.Name = "splitContainerTablesPreview";
            // 
            // splitContainerTablesPreview.Panel1
            // 
            this.splitContainerTablesPreview.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainerTablesPreview.Panel2
            // 
            this.splitContainerTablesPreview.Panel2.Controls.Add(this.spltCntTablesData);
            this.splitContainerTablesPreview.Size = new System.Drawing.Size(1294, 560);
            this.splitContainerTablesPreview.SplitterDistance = 204;
            this.splitContainerTablesPreview.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer4.Size = new System.Drawing.Size(204, 560);
            this.splitContainer4.SplitterDistance = 212;
            this.splitContainer4.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer2.Panel1.Controls.Add(this.lblCatalogTree);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeViewTablesCatalog);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Size = new System.Drawing.Size(200, 208);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblCatalogTree
            // 
            this.lblCatalogTree.AutoSize = true;
            this.lblCatalogTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatalogTree.Location = new System.Drawing.Point(6, 5);
            this.lblCatalogTree.Name = "lblCatalogTree";
            this.lblCatalogTree.Size = new System.Drawing.Size(85, 17);
            this.lblCatalogTree.TabIndex = 0;
            this.lblCatalogTree.Text = "Catalog tree";
            // 
            // splitContainer8
            // 
            this.splitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer8.Size = new System.Drawing.Size(204, 344);
            this.splitContainer8.SplitterDistance = 164;
            this.splitContainer8.TabIndex = 2;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer6.Panel1.Controls.Add(this.lblSelectedTableInfo);
            this.splitContainer6.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.pgrdTableInfo);
            this.splitContainer6.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer6.Size = new System.Drawing.Size(200, 172);
            this.splitContainer6.SplitterDistance = 25;
            this.splitContainer6.TabIndex = 1;
            // 
            // lblSelectedTableInfo
            // 
            this.lblSelectedTableInfo.AutoSize = true;
            this.lblSelectedTableInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedTableInfo.Location = new System.Drawing.Point(6, 5);
            this.lblSelectedTableInfo.Name = "lblSelectedTableInfo";
            this.lblSelectedTableInfo.Size = new System.Drawing.Size(121, 17);
            this.lblSelectedTableInfo.TabIndex = 0;
            this.lblSelectedTableInfo.Text = "Opened table info";
            // 
            // pgrdTableInfo
            // 
            this.pgrdTableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgrdTableInfo.Location = new System.Drawing.Point(3, 3);
            this.pgrdTableInfo.Name = "pgrdTableInfo";
            this.pgrdTableInfo.Size = new System.Drawing.Size(194, 137);
            this.pgrdTableInfo.TabIndex = 0;
            // 
            // spltCntTablesData
            // 
            this.spltCntTablesData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spltCntTablesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltCntTablesData.Location = new System.Drawing.Point(0, 0);
            this.spltCntTablesData.Name = "spltCntTablesData";
            this.spltCntTablesData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltCntTablesData.Panel1
            // 
            this.spltCntTablesData.Panel1.Controls.Add(this.splitContainer1);
            this.spltCntTablesData.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // spltCntTablesData.Panel2
            // 
            this.spltCntTablesData.Panel2.Controls.Add(this.splitContainer3);
            this.spltCntTablesData.Size = new System.Drawing.Size(1086, 560);
            this.spltCntTablesData.SplitterDistance = 333;
            this.spltCntTablesData.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer1.Panel1.Controls.Add(this.lblDiagramHeader);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 325);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblDiagramHeader
            // 
            this.lblDiagramHeader.AutoSize = true;
            this.lblDiagramHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiagramHeader.Location = new System.Drawing.Point(6, 5);
            this.lblDiagramHeader.Name = "lblDiagramHeader";
            this.lblDiagramHeader.Size = new System.Drawing.Size(82, 17);
            this.lblDiagramHeader.TabIndex = 0;
            this.lblDiagramHeader.Text = "Tables map";
            // 
            // splitContainer9
            // 
            this.splitContainer9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer9.IsSplitterFixed = true;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer9.Panel1.Controls.Add(this.btnPlaceTable);
            this.splitContainer9.Panel1.Controls.Add(this.btnDeleteTables);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.tablesField);
            this.splitContainer9.Size = new System.Drawing.Size(1078, 296);
            this.splitContainer9.SplitterDistance = 42;
            this.splitContainer9.TabIndex = 1;
            // 
            // btnPlaceTable
            // 
            this.btnPlaceTable.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaceTable.FlatAppearance.BorderSize = 0;
            this.btnPlaceTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceTable.Image = global::STS.Workbench.Properties.Resources.table_add;
            this.btnPlaceTable.Location = new System.Drawing.Point(2, 3);
            this.btnPlaceTable.Name = "btnPlaceTable";
            this.btnPlaceTable.Size = new System.Drawing.Size(35, 40);
            this.btnPlaceTable.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnPlaceTable, "Place new table");
            this.btnPlaceTable.UseVisualStyleBackColor = false;
            this.btnPlaceTable.Click += new System.EventHandler(this.btnPlaceTable_Click);
            // 
            // btnDeleteTables
            // 
            this.btnDeleteTables.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTables.FlatAppearance.BorderSize = 0;
            this.btnDeleteTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTables.Image = global::STS.Workbench.Properties.Resources.table_delete;
            this.btnDeleteTables.Location = new System.Drawing.Point(3, 49);
            this.btnDeleteTables.Name = "btnDeleteTables";
            this.btnDeleteTables.Size = new System.Drawing.Size(35, 40);
            this.btnDeleteTables.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteTables, "Delete selected table/s");
            this.btnDeleteTables.UseVisualStyleBackColor = false;
            this.btnDeleteTables.Click += new System.EventHandler(this.btnDeleteTables_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer3.Panel1.Controls.Add(this.btnHideData);
            this.splitContainer3.Panel1.Controls.Add(this.btnSelectAllRows);
            this.splitContainer3.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer3.Panel1.Controls.Add(this.lblImportExport);
            this.splitContainer3.Panel1.Controls.Add(this.lblEditRows);
            this.splitContainer3.Panel1.Controls.Add(this.lblChanges);
            this.splitContainer3.Panel1.Controls.Add(this.btnDiscard);
            this.splitContainer3.Panel1.Controls.Add(this.btnExport);
            this.splitContainer3.Panel1.Controls.Add(this.btnImport);
            this.splitContainer3.Panel1.Controls.Add(this.btnDeleteRows);
            this.splitContainer3.Panel1.Controls.Add(this.btnSaveRowChanges);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer3.Size = new System.Drawing.Size(1086, 223);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnHideData
            // 
            this.btnHideData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideData.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideData.Image = global::STS.Workbench.Properties.Resources.sort_down;
            this.btnHideData.Location = new System.Drawing.Point(1031, 1);
            this.btnHideData.Name = "btnHideData";
            this.btnHideData.Size = new System.Drawing.Size(48, 24);
            this.btnHideData.TabIndex = 13;
            this.toolTip.SetToolTip(this.btnHideData, "Close opened table");
            this.btnHideData.UseVisualStyleBackColor = false;
            this.btnHideData.Click += new System.EventHandler(this.btnHideData_Click);
            // 
            // btnSelectAllRows
            // 
            this.btnSelectAllRows.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectAllRows.FlatAppearance.BorderSize = 0;
            this.btnSelectAllRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAllRows.Image = global::STS.Workbench.Properties.Resources.gnome_edit_select_all;
            this.btnSelectAllRows.Location = new System.Drawing.Point(93, 1);
            this.btnSelectAllRows.Name = "btnSelectAllRows";
            this.btnSelectAllRows.Size = new System.Drawing.Size(24, 24);
            this.btnSelectAllRows.TabIndex = 12;
            this.toolTip.SetToolTip(this.btnSelectAllRows, "Select all rows");
            this.btnSelectAllRows.UseVisualStyleBackColor = false;
            this.btnSelectAllRows.Click += new System.EventHandler(this.btnSelectAllRows_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::STS.Workbench.Properties.Resources.view_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(257, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnRefresh, "Refresh data");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblImportExport
            // 
            this.lblImportExport.AutoSize = true;
            this.lblImportExport.Location = new System.Drawing.Point(304, 8);
            this.lblImportExport.Name = "lblImportExport";
            this.lblImportExport.Size = new System.Drawing.Size(74, 13);
            this.lblImportExport.TabIndex = 10;
            this.lblImportExport.Text = "Import/Export:";
            // 
            // lblEditRows
            // 
            this.lblEditRows.AutoSize = true;
            this.lblEditRows.Location = new System.Drawing.Point(4, 7);
            this.lblEditRows.Name = "lblEditRows";
            this.lblEditRows.Size = new System.Drawing.Size(53, 13);
            this.lblEditRows.TabIndex = 7;
            this.lblEditRows.Text = "Edit rows:";
            // 
            // lblChanges
            // 
            this.lblChanges.AutoSize = true;
            this.lblChanges.Location = new System.Drawing.Point(139, 7);
            this.lblChanges.Name = "lblChanges";
            this.lblChanges.Size = new System.Drawing.Size(52, 13);
            this.lblChanges.TabIndex = 6;
            this.lblChanges.Text = "Changes:";
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Image = global::STS.Workbench.Properties.Resources.undo;
            this.btnDiscard.Location = new System.Drawing.Point(227, 1);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(24, 24);
            this.btnDiscard.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnDiscard, "Discard changes to data");
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = global::STS.Workbench.Properties.Resources.document_export;
            this.btnExport.Location = new System.Drawing.Point(415, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(24, 24);
            this.btnExport.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnExport, "Export data to external file");
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Image = global::STS.Workbench.Properties.Resources.document_import;
            this.btnImport.Location = new System.Drawing.Point(385, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(24, 24);
            this.btnImport.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnImport, "Import data from external file");
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImportCsv_Click);
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRows.FlatAppearance.BorderSize = 0;
            this.btnDeleteRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRows.Image = global::STS.Workbench.Properties.Resources.Delete;
            this.btnDeleteRows.Location = new System.Drawing.Point(63, 1);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteRows.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnDeleteRows, "Delete selected row/rowss");
            this.btnDeleteRows.UseVisualStyleBackColor = false;
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnSaveRowChanges
            // 
            this.btnSaveRowChanges.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveRowChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveRowChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRowChanges.Image = global::STS.Workbench.Properties.Resources.Save;
            this.btnSaveRowChanges.Location = new System.Drawing.Point(197, 2);
            this.btnSaveRowChanges.Name = "btnSaveRowChanges";
            this.btnSaveRowChanges.Size = new System.Drawing.Size(24, 24);
            this.btnSaveRowChanges.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnSaveRowChanges, "Apply changes to data");
            this.btnSaveRowChanges.UseVisualStyleBackColor = false;
            this.btnSaveRowChanges.Click += new System.EventHandler(this.btnSaveRowChanges_Click);
            // 
            // splitContainer7
            // 
            this.splitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.grdViewTableRecords);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer7.Panel2.Controls.Add(this.btnLastPage);
            this.splitContainer7.Panel2.Controls.Add(this.btnNextPage);
            this.splitContainer7.Panel2.Controls.Add(this.btnPreviousPage);
            this.splitContainer7.Panel2.Controls.Add(this.btnFirstPage);
            this.splitContainer7.Panel2.Controls.Add(this.cmbxPageCount);
            this.splitContainer7.Panel2.Controls.Add(this.label3);
            this.splitContainer7.Size = new System.Drawing.Size(1086, 190);
            this.splitContainer7.SplitterDistance = 155;
            this.splitContainer7.TabIndex = 4;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Image = global::STS.Workbench.Properties.Resources.button_last;
            this.btnLastPage.Location = new System.Drawing.Point(93, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(24, 24);
            this.btnLastPage.TabIndex = 11;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Image = global::STS.Workbench.Properties.Resources.go_next;
            this.btnNextPage.Location = new System.Drawing.Point(63, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(24, 24);
            this.btnNextPage.TabIndex = 10;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Image = global::STS.Workbench.Properties.Resources.go_back;
            this.btnPreviousPage.Location = new System.Drawing.Point(33, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(24, 24);
            this.btnPreviousPage.TabIndex = 9;
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.FlatAppearance.BorderSize = 0;
            this.btnFirstPage.Image = global::STS.Workbench.Properties.Resources.button_first;
            this.btnFirstPage.Location = new System.Drawing.Point(3, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(24, 24);
            this.btnFirstPage.TabIndex = 8;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // cmbxPageCount
            // 
            this.cmbxPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPageCount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbxPageCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPageCount.FormattingEnabled = true;
            this.cmbxPageCount.Items.AddRange(new object[] {
            "2",
            "5",
            "10",
            "20",
            "50",
            "100",
            "200",
            "500",
            "1000",
            "2000",
            "5000",
            "10000",
            "20000",
            "50000",
            "100000"});
            this.cmbxPageCount.Location = new System.Drawing.Point(958, 3);
            this.cmbxPageCount.Name = "cmbxPageCount";
            this.cmbxPageCount.Size = new System.Drawing.Size(121, 21);
            this.cmbxPageCount.TabIndex = 8;
            this.toolTip.SetToolTip(this.cmbxPageCount, "Change displaying records count");
            this.cmbxPageCount.SelectedValueChanged += new System.EventHandler(this.cmbxPageCount_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(909, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Paging:";
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainerMain.IsSplitterFixed = true;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            this.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.SplitContainerMain.Panel1.Controls.Add(this.mStripMain);
            this.SplitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.splitContainerTablesPreview);
            this.SplitContainerMain.Size = new System.Drawing.Size(1294, 601);
            this.SplitContainerMain.SplitterDistance = 37;
            this.SplitContainerMain.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer5
            // 
            this.splitContainer5.BackColor = System.Drawing.Color.White;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.SplitContainerMain);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.splitContainer5.Panel2.Controls.Add(this.lblInfo);
            this.splitContainer5.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer5.Size = new System.Drawing.Size(1294, 630);
            this.splitContainer5.SplitterDistance = 601;
            this.splitContainer5.TabIndex = 10;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(3, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // mStripTables
            // 
            this.mStripTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.pasteDataToolStripMenuItem,
            this.toolStripSeparator3,
            this.editColorsToolStripMenuItem,
            this.toolStripSeparator4,
            this.propertiesToolStripMenuItem});
            this.mStripTables.Name = "menuStripTables";
            this.mStripTables.Size = new System.Drawing.Size(130, 154);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteDataToolStripMenuItem
            // 
            this.pasteDataToolStripMenuItem.Name = "pasteDataToolStripMenuItem";
            this.pasteDataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pasteDataToolStripMenuItem.Text = "Paste data";
            this.pasteDataToolStripMenuItem.Click += new System.EventHandler(this.pasteDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // editColorsToolStripMenuItem
            // 
            this.editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            this.editColorsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editColorsToolStripMenuItem.Text = "Edit colors";
            this.editColorsToolStripMenuItem.Click += new System.EventHandler(this.editColorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(126, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // mStripTablesField
            // 
            this.mStripTablesField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.expandToolStripMenuItem,
            this.collapseToolStripMenuItem,
            this.toolStripSeparator6,
            this.sizeToolStripMenuItem,
            this.toolStripSeparator8,
            this.sortToolStripMenuItem,
            this.toolStripSeparator5,
            this.loadOrderToolStripMenuItem,
            this.saveOrderToolStripMenuItem});
            this.mStripTablesField.Name = "MenuStripTablesField";
            this.mStripTablesField.Size = new System.Drawing.Size(127, 232);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.collapseToolStripMenuItem.Text = "Collapse";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.collapseToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(123, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(123, 6);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.incrase2xToolStripMenuItem,
            this.decrase2xToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // incrase2xToolStripMenuItem
            // 
            this.incrase2xToolStripMenuItem.Name = "incrase2xToolStripMenuItem";
            this.incrase2xToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.incrase2xToolStripMenuItem.Text = "Incrase by 25%";
            this.incrase2xToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // decrase2xToolStripMenuItem
            // 
            this.decrase2xToolStripMenuItem.Name = "decrase2xToolStripMenuItem";
            this.decrase2xToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.decrase2xToolStripMenuItem.Text = "Decrase by 25%";
            this.decrase2xToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(123, 6);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(123, 6);
            // 
            // saveOrderToolStripMenuItem
            // 
            this.saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
            this.saveOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveOrderToolStripMenuItem.Text = "Save field";
            this.saveOrderToolStripMenuItem.Click += new System.EventHandler(this.saveOrderToolStripMenuItem_Click);
            // 
            // loadOrderToolStripMenuItem
            // 
            this.loadOrderToolStripMenuItem.Name = "loadOrderToolStripMenuItem";
            this.loadOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadOrderToolStripMenuItem.Text = "Load field";
            this.loadOrderToolStripMenuItem.Click += new System.EventHandler(this.loadOrderToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // mStripCatalogDb
            // 
            this.mStripCatalogDb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitToolStripMenuItem});
            this.mStripCatalogDb.Name = "mStripCatalogDb";
            this.mStripCatalogDb.Size = new System.Drawing.Size(119, 26);
            // 
            // commitToolStripMenuItem
            // 
            this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            this.commitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.commitToolStripMenuItem.Text = "Commit";
            // 
            // mStripCatalogTables
            // 
            this.mStripCatalogTables.Name = "mStripCatalogTables";
            this.mStripCatalogTables.Size = new System.Drawing.Size(61, 4);
            // 
            // mStripMain
            // 
            this.mStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mStripMain.Location = new System.Drawing.Point(0, 2);
            this.mStripMain.Name = "mStripMain";
            this.mStripMain.Size = new System.Drawing.Size(1294, 24);
            this.mStripMain.TabIndex = 17;
            this.mStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // tablesField
            // 
            this.tablesField.AutoScroll = true;
            this.tablesField.BackColor = System.Drawing.Color.White;
            this.tablesField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesField.Location = new System.Drawing.Point(0, 0);
            this.tablesField.Name = "tablesField";
            this.tablesField.Size = new System.Drawing.Size(1030, 294);
            this.tablesField.TabIndex = 0;
            this.tablesField.Click += new System.EventHandler(this.tablesField_Click);
            this.tablesField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.tablesField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.On_MouseMove);
            this.tablesField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // TablesDiagramPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.splitContainer5);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "TablesDiagramPreview";
            this.Size = new System.Drawing.Size(1294, 630);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTableRecords)).EndInit();
            this.splitContainerTablesPreview.Panel1.ResumeLayout(false);
            this.splitContainerTablesPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTablesPreview)).EndInit();
            this.splitContainerTablesPreview.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.spltCntTablesData.Panel1.ResumeLayout(false);
            this.spltCntTablesData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltCntTablesData)).EndInit();
            this.spltCntTablesData.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel1.PerformLayout();
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.mStripTables.ResumeLayout(false);
            this.mStripTablesField.ResumeLayout(false);
            this.mStripCatalogDb.ResumeLayout(false);
            this.mStripMain.ResumeLayout(false);
            this.mStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewTableRecords;
        private System.Windows.Forms.TreeView treeViewTablesCatalog;
        private SplitContainer splitContainerTablesPreview;
        private SplitContainer spltCntTablesData;
        private Button btnPlaceTable;
        private Button btnDeleteTables;
        private SplitContainer splitContainer3;
        private Button btnSaveRowChanges;
        private SplitContainer splitContainer4;
        private SplitContainer SplitContainerMain;
        private Button btnExport;
        private Button btnImport;
        private Button btnDeleteRows;
        private Button btnDiscard;
        private Label lblEditRows;
        private Label lblChanges;
        private SplitContainer splitContainer7;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private Button btnFirstPage;
        private Label label3;
        private ComboBox cmbxPageCount;
        private Label lblImportExport;
        private Timer timer1;
        private Button btnRefresh;
        private Button btnSelectAllRows;
        private ToolTip toolTip;
        private SplitContainer splitContainer9;
        private Button btnHideData;
        private Button btnLastPage;
        private SplitContainer splitContainer2;
        private Label lblCatalogTree;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private Label lblSelectedTableInfo;
        private PropertyGrid pgrdTableInfo;
        private SplitContainer splitContainer8;
        private Label lblInfo;
        private TablesDiagram.DiagramPreviewComponents.FieldControl tablesField;
        private SplitContainer splitContainer1;
        private Label lblDiagramHeader;
        private ContextMenuStrip mStripTables;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem editColorsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private ToolStripMenuItem pasteDataToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ContextMenuStrip mStripTablesField;
        private ToolStripMenuItem collapseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem sortToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem saveOrderToolStripMenuItem;
        private ToolStripMenuItem loadOrderToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem incrase2xToolStripMenuItem;
        private ToolStripMenuItem decrase2xToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem expandToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ContextMenuStrip mStripCatalogDb;
        private ToolStripMenuItem commitToolStripMenuItem;
        private ContextMenuStrip mStripCatalogTables;
        private MenuStrip mStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
