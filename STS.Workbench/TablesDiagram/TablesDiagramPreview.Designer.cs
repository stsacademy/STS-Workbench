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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("myDb");
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPlaceTable = new System.Windows.Forms.Button();
            this.btnDeleteTables = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.mStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainerTablesPreview = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblCatalogTree = new System.Windows.Forms.Label();
            this.treeViewTablesCatalog = new System.Windows.Forms.TreeView();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.lblTest = new System.Windows.Forms.Label();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.lblSelectedTableInfo = new System.Windows.Forms.Label();
            this.pgrdTableInfo = new System.Windows.Forms.PropertyGrid();
            this.spltCntTablesData = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDiagramHeader = new System.Windows.Forms.Label();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStripTableEdit = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDeleteRows = new System.Windows.Forms.ToolStripButton();
            this.btnSelectAllRows = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveRowChanges = new System.Windows.Forms.ToolStripButton();
            this.btnDiscard = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnChartWizard = new System.Windows.Forms.ToolStripButton();
            this.btnCloseTable = new System.Windows.Forms.ToolStripButton();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.grdViewTableRecords = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripTablesField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrase2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrase2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.loadOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripCatalogDb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripCatalogTables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFirstPage = new System.Windows.Forms.ToolStripButton();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.btnLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelPaging = new System.Windows.Forms.ToolStripLabel();
            this.cmbPageCapacity = new System.Windows.Forms.ToolStripComboBox();
            this.tablesField = new STS.Workbench.TablesDiagram.DiagramPreviewComponents.FieldControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.mStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
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
            this.splitContainer8.Panel1.SuspendLayout();
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
            this.toolStripTableEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTableRecords)).BeginInit();
            this.mStripTable.SuspendLayout();
            this.mStripTablesField.SuspendLayout();
            this.mStripCatalogDb.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnDeleteTables.Location = new System.Drawing.Point(2, 49);
            this.btnDeleteTables.Name = "btnDeleteTables";
            this.btnDeleteTables.Size = new System.Drawing.Size(35, 40);
            this.btnDeleteTables.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnDeleteTables, "Delete selected table/s");
            this.btnDeleteTables.UseVisualStyleBackColor = false;
            this.btnDeleteTables.Click += new System.EventHandler(this.btnDeleteTables_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.splitContainerMain.Panel1.Controls.Add(this.mStripMain);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainerMain.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Size = new System.Drawing.Size(1458, 636);
            this.splitContainerMain.SplitterDistance = 35;
            this.splitContainerMain.SplitterWidth = 6;
            this.splitContainerMain.TabIndex = 10;
            // 
            // mStripMain
            // 
            this.mStripMain.BackgroundImage = global::STS.Workbench.Properties.Resources.MenuStripBackGround;
            this.mStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mStripMain.Location = new System.Drawing.Point(2, 4);
            this.mStripMain.Name = "mStripMain";
            this.mStripMain.Size = new System.Drawing.Size(1452, 24);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(4, 4);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.splitContainerTablesPreview);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.splitContainer5.Panel2.Controls.Add(this.lblInfo);
            this.splitContainer5.Panel2.Padding = new System.Windows.Forms.Padding(2, 7, 5, 7);
            this.splitContainer5.Size = new System.Drawing.Size(1448, 585);
            this.splitContainer5.SplitterDistance = 559;
            this.splitContainer5.SplitterWidth = 1;
            this.splitContainer5.TabIndex = 6;
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
            this.splitContainerTablesPreview.Size = new System.Drawing.Size(1448, 559);
            this.splitContainerTablesPreview.SplitterDistance = 204;
            this.splitContainerTablesPreview.TabIndex = 5;
            // 
            // splitContainer4
            // 
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
            this.splitContainer4.Size = new System.Drawing.Size(200, 555);
            this.splitContainer4.SplitterDistance = 174;
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
            this.splitContainer2.Size = new System.Drawing.Size(200, 174);
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
            // treeViewTablesCatalog
            // 
            this.treeViewTablesCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTablesCatalog.Location = new System.Drawing.Point(3, 3);
            this.treeViewTablesCatalog.Name = "treeViewTablesCatalog";
            treeNode1.Name = "trvCatalogTree";
            treeNode1.Text = "myDb";
            this.treeViewTablesCatalog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewTablesCatalog.Size = new System.Drawing.Size(194, 139);
            this.treeViewTablesCatalog.TabIndex = 4;
            this.treeViewTablesCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTablesCatalog_AfterSelect);
            this.treeViewTablesCatalog.DoubleClick += new System.EventHandler(this.treeViewTablesCatalog_DoubleClick);
            // 
            // splitContainer8
            // 
            this.splitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer8.Panel1.Controls.Add(this.lblTest);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer8.Size = new System.Drawing.Size(200, 377);
            this.splitContainer8.SplitterDistance = 173;
            this.splitContainer8.TabIndex = 2;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(16, 13);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(28, 13);
            this.lblTest.TabIndex = 8;
            this.lblTest.Text = "Test";
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
            this.splitContainer6.Size = new System.Drawing.Size(198, 198);
            this.splitContainer6.SplitterDistance = 25;
            this.splitContainer6.SplitterWidth = 1;
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
            this.pgrdTableInfo.Size = new System.Drawing.Size(192, 166);
            this.pgrdTableInfo.TabIndex = 0;
            // 
            // spltCntTablesData
            // 
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
            this.spltCntTablesData.Size = new System.Drawing.Size(1236, 555);
            this.spltCntTablesData.SplitterDistance = 284;
            this.spltCntTablesData.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.splitContainer1.Size = new System.Drawing.Size(1232, 280);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblDiagramHeader
            // 
            this.lblDiagramHeader.AutoSize = true;
            this.lblDiagramHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiagramHeader.Location = new System.Drawing.Point(2, 2);
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
            this.splitContainer9.Size = new System.Drawing.Size(1232, 254);
            this.splitContainer9.SplitterDistance = 42;
            this.splitContainer9.SplitterWidth = 1;
            this.splitContainer9.TabIndex = 1;
            // 
            // splitContainer3
            // 
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
            this.splitContainer3.Panel1.Controls.Add(this.toolStripTableEdit);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer3.Size = new System.Drawing.Size(1236, 267);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 4;
            // 
            // toolStripTableEdit
            // 
            this.toolStripTableEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.toolStripTableEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripTableEdit.GripMargin = new System.Windows.Forms.Padding(3);
            this.toolStripTableEdit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTableEdit.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.toolStripTableEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnDeleteRows,
            this.btnSelectAllRows,
            this.toolStripSeparator9,
            this.toolStripLabel2,
            this.btnSaveRowChanges,
            this.btnDiscard,
            this.btnRefresh,
            this.toolStripSeparator10,
            this.toolStripLabel3,
            this.btnImport,
            this.btnExport,
            this.toolStripSeparator11,
            this.toolStripLabel4,
            this.btnChartWizard,
            this.btnCloseTable});
            this.toolStripTableEdit.Location = new System.Drawing.Point(0, 0);
            this.toolStripTableEdit.Name = "toolStripTableEdit";
            this.toolStripTableEdit.Size = new System.Drawing.Size(1236, 29);
            this.toolStripTableEdit.TabIndex = 0;
            this.toolStripTableEdit.Text = "Close table";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 26);
            this.toolStripLabel1.Text = "Edit Rows: ";
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteRows.Image = global::STS.Workbench.Properties.Resources.symbol_remove;
            this.btnDeleteRows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(23, 26);
            this.btnDeleteRows.Text = "Delete Rows";
            this.btnDeleteRows.ToolTipText = "Delete selected row/rowss";
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnSelectAllRows
            // 
            this.btnSelectAllRows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectAllRows.Image = global::STS.Workbench.Properties.Resources.edit_select_all__1_;
            this.btnSelectAllRows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectAllRows.Name = "btnSelectAllRows";
            this.btnSelectAllRows.Size = new System.Drawing.Size(23, 26);
            this.btnSelectAllRows.Text = "Select all rows";
            this.btnSelectAllRows.ToolTipText = "Select all rows";
            this.btnSelectAllRows.Click += new System.EventHandler(this.btnSelectAllRows_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.BackColor = System.Drawing.Color.Black;
            this.toolStripSeparator9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 26);
            this.toolStripLabel2.Text = "Changes: ";
            // 
            // btnSaveRowChanges
            // 
            this.btnSaveRowChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveRowChanges.Image = global::STS.Workbench.Properties.Resources.save__1_;
            this.btnSaveRowChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveRowChanges.Name = "btnSaveRowChanges";
            this.btnSaveRowChanges.Size = new System.Drawing.Size(23, 26);
            this.btnSaveRowChanges.Text = "Flush";
            this.btnSaveRowChanges.ToolTipText = "Apply changes to data";
            this.btnSaveRowChanges.Click += new System.EventHandler(this.btnSaveRowChanges_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDiscard.Image = global::STS.Workbench.Properties.Resources.undo;
            this.btnDiscard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(23, 26);
            this.btnDiscard.Text = "Disard";
            this.btnDiscard.ToolTipText = "Discard changes to data";
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::STS.Workbench.Properties.Resources.view_refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 26);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(87, 26);
            this.toolStripLabel3.Text = "Import/Export: ";
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = global::STS.Workbench.Properties.Resources.document_import;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(23, 26);
            this.btnImport.Text = "Import";
            this.btnImport.ToolTipText = "Import data from external file";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = global::STS.Workbench.Properties.Resources.document_export;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 26);
            this.btnExport.Text = "Export";
            this.btnExport.ToolTipText = "Export data to external file";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(47, 26);
            this.toolStripLabel4.Text = "Charts: ";
            // 
            // btnChartWizard
            // 
            this.btnChartWizard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChartWizard.Image = global::STS.Workbench.Properties.Resources.chart_bar;
            this.btnChartWizard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChartWizard.Name = "btnChartWizard";
            this.btnChartWizard.Size = new System.Drawing.Size(23, 26);
            this.btnChartWizard.Text = "Chart wiazard";
            this.btnChartWizard.Click += new System.EventHandler(this.btnChartWizard_Click);
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnCloseTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseTable.Image = global::STS.Workbench.Properties.Resources.sort_down;
            this.btnCloseTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseTable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(23, 23);
            this.btnCloseTable.Text = "Close/hide table";
            this.btnCloseTable.Click += new System.EventHandler(this.btnCloseTable_Click);
            // 
            // splitContainer7
            // 
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
            this.splitContainer7.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer7.Size = new System.Drawing.Size(1236, 237);
            this.splitContainer7.SplitterDistance = 211;
            this.splitContainer7.SplitterWidth = 1;
            this.splitContainer7.TabIndex = 4;
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
            this.grdViewTableRecords.Size = new System.Drawing.Size(1236, 211);
            this.grdViewTableRecords.TabIndex = 3;
            this.grdViewTableRecords.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdViewTableRecords_CellMouseClick);
            this.grdViewTableRecords.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewTableRecords_CellValueChanged);
            this.grdViewTableRecords.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdViewTableRecords_UserAddedRow);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(5, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 0;
            // 
            // mStripTable
            // 
            this.mStripTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.copyToolStripMenuItem,
            this.pasteDataToolStripMenuItem,
            this.toolStripSeparator3,
            this.editColorsToolStripMenuItem,
            this.toolStripSeparator4,
            this.propertiesToolStripMenuItem});
            this.mStripTable.Name = "menuStripTables";
            this.mStripTable.Size = new System.Drawing.Size(162, 176);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteDataToolStripMenuItem
            // 
            this.pasteDataToolStripMenuItem.Name = "pasteDataToolStripMenuItem";
            this.pasteDataToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pasteDataToolStripMenuItem.Text = "Paste data";
            this.pasteDataToolStripMenuItem.Click += new System.EventHandler(this.pasteDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // editColorsToolStripMenuItem
            // 
            this.editColorsToolStripMenuItem.Name = "editColorsToolStripMenuItem";
            this.editColorsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editColorsToolStripMenuItem.Text = "Backgroud color";
            this.editColorsToolStripMenuItem.Click += new System.EventHandler(this.editColorsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
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
            this.deleteToolStripMenuItem1,
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
            this.mStripTablesField.Size = new System.Drawing.Size(127, 254);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(123, 6);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.collapseToolStripMenuItem.Text = "Collapse";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.collapseToolStripMenuItem_Click);
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
            // loadOrderToolStripMenuItem
            // 
            this.loadOrderToolStripMenuItem.Name = "loadOrderToolStripMenuItem";
            this.loadOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.loadOrderToolStripMenuItem.Text = "Load field";
            this.loadOrderToolStripMenuItem.Click += new System.EventHandler(this.loadOrderToolStripMenuItem_Click);
            // 
            // saveOrderToolStripMenuItem
            // 
            this.saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
            this.saveOrderToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveOrderToolStripMenuItem.Text = "Save field";
            this.saveOrderToolStripMenuItem.Click += new System.EventHandler(this.saveOrderToolStripMenuItem_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirstPage,
            this.btnPreviousPage,
            this.btnNextPage,
            this.btnLastPage,
            this.cmbPageCapacity,
            this.toolStripLabelPaging});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1236, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirstPage.Image = global::STS.Workbench.Properties.Resources.button_first;
            this.btnFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(28, 28);
            this.btnFirstPage.Text = "first page";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = global::STS.Workbench.Properties.Resources.go_back;
            this.btnPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(28, 28);
            this.btnPreviousPage.Text = "previous page";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = global::STS.Workbench.Properties.Resources.go_next;
            this.btnNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 28);
            this.btnNextPage.Text = "next page";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastPage.Image = global::STS.Workbench.Properties.Resources.button_last;
            this.btnLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(28, 28);
            this.btnLastPage.Text = "last page";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // toolStripLabelPaging
            // 
            this.toolStripLabelPaging.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelPaging.Name = "toolStripLabelPaging";
            this.toolStripLabelPaging.Size = new System.Drawing.Size(47, 28);
            this.toolStripLabelPaging.Text = "Paging:";
            // 
            // cmbPageCapacity
            // 
            this.cmbPageCapacity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbPageCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.cmbPageCapacity.Items.AddRange(new object[] {
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
            this.cmbPageCapacity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.cmbPageCapacity.Name = "cmbPageCapacity";
            this.cmbPageCapacity.Size = new System.Drawing.Size(121, 31);
            this.cmbPageCapacity.SelectedIndexChanged += new System.EventHandler(this.cmbxPageCount_SelectedValueChanged);
            // 
            // tablesField
            // 
            this.tablesField.AutoScroll = true;
            this.tablesField.BackColor = System.Drawing.Color.White;
            this.tablesField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablesField.Location = new System.Drawing.Point(0, 0);
            this.tablesField.Name = "tablesField";
            this.tablesField.Size = new System.Drawing.Size(1187, 252);
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
            this.Controls.Add(this.splitContainerMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "TablesDiagramPreview";
            this.Size = new System.Drawing.Size(1458, 636);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.mStripMain.ResumeLayout(false);
            this.mStripMain.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
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
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
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
            this.toolStripTableEdit.ResumeLayout(false);
            this.toolStripTableEdit.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTableRecords)).EndInit();
            this.mStripTable.ResumeLayout(false);
            this.mStripTablesField.ResumeLayout(false);
            this.mStripCatalogDb.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer7;
        private Timer timer1;
        private ToolTip toolTip;
        private SplitContainer splitContainer9;
        private SplitContainer splitContainer2;
        private Label lblCatalogTree;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainer6;
        private Label lblSelectedTableInfo;
        private PropertyGrid pgrdTableInfo;
        private SplitContainer splitContainer8;
        private TablesDiagram.DiagramPreviewComponents.FieldControl tablesField;
        private SplitContainer splitContainer1;
        private Label lblDiagramHeader;
        private ContextMenuStrip mStripTable;
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
        private SplitContainer splitContainer5;
        private Label lblInfo;
        private ToolStrip toolStripTableEdit;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnDeleteRows;
        private ToolStripButton btnSelectAllRows;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton btnSaveRowChanges;
        private ToolStripButton btnDiscard;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton btnImport;
        private ToolStripButton btnExport;
        private Label lblTest;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton btnChartWizard;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton btnCloseTable;
        private ToolStrip toolStrip1;
        private ToolStripButton btnFirstPage;
        private ToolStripButton btnPreviousPage;
        private ToolStripButton btnNextPage;
        private ToolStripButton btnLastPage;
        private ToolStripComboBox cmbPageCapacity;
        private ToolStripLabel toolStripLabelPaging;
    }
}
