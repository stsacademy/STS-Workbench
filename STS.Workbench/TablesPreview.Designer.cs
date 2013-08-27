using System.Windows.Forms;
namespace STS.Workbench
{
    partial class TablesPreview
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("myDb");
            this.grdViewTableRecords = new System.Windows.Forms.DataGridView();
            this.treeViewTablesCatalog = new System.Windows.Forms.TreeView();
            this.splitContainerTablesPreview = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnSaveRow = new System.Windows.Forms.Button();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.btnPlaceTable = new System.Windows.Forms.Button();
            this.btnCancelTable = new System.Windows.Forms.Button();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableAddComponent = new STS.Workbench.PreviewComponents.TableAddComponent();
            this.ucrlTablesField = new STS.Workbench.PreviewComponents.TablesField();
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
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewTableRecords
            // 
            this.grdViewTableRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewTableRecords.ColumnHeadersVisible = false;
            this.grdViewTableRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewTableRecords.Location = new System.Drawing.Point(0, 0);
            this.grdViewTableRecords.Name = "grdViewTableRecords";
            this.grdViewTableRecords.RowHeadersVisible = false;
            this.grdViewTableRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdViewTableRecords.Size = new System.Drawing.Size(1125, 140);
            this.grdViewTableRecords.TabIndex = 3;
            this.grdViewTableRecords.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdViewTableRecords_UserAddedRow);
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
            this.treeViewTablesCatalog.Size = new System.Drawing.Size(193, 151);
            this.treeViewTablesCatalog.TabIndex = 4;
            this.treeViewTablesCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTablesCatalog_AfterSelect);
            // 
            // splitContainerTablesPreview
            // 
            this.splitContainerTablesPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTablesPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTablesPreview.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTablesPreview.IsSplitterFixed = true;
            this.splitContainerTablesPreview.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTablesPreview.Name = "splitContainerTablesPreview";
            // 
            // splitContainerTablesPreview.Panel1
            // 
            this.splitContainerTablesPreview.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainerTablesPreview.Panel2
            // 
            this.splitContainerTablesPreview.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerTablesPreview.Size = new System.Drawing.Size(1336, 626);
            this.splitContainerTablesPreview.SplitterDistance = 203;
            this.splitContainerTablesPreview.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tableAddComponent);
            this.splitContainer4.Panel1MinSize = 250;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer4.Size = new System.Drawing.Size(203, 626);
            this.splitContainer4.SplitterDistance = 257;
            this.splitContainer4.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewTablesCatalog);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Size = new System.Drawing.Size(203, 365);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.ucrlTablesField);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1129, 626);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 4;
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
            this.splitContainer3.Panel1.Controls.Add(this.btnSaveRow);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grdViewTableRecords);
            this.splitContainer3.Size = new System.Drawing.Size(1129, 177);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnSaveRow
            // 
            this.btnSaveRow.Location = new System.Drawing.Point(3, 3);
            this.btnSaveRow.Name = "btnSaveRow";
            this.btnSaveRow.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRow.TabIndex = 0;
            this.btnSaveRow.Text = "Save";
            this.btnSaveRow.UseVisualStyleBackColor = true;
            this.btnSaveRow.Click += new System.EventHandler(this.btnSaveRow_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Location = new System.Drawing.Point(199, 6);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(92, 31);
            this.btnRemoveTable.TabIndex = 7;
            this.btnRemoveTable.Text = "Remove table";
            this.btnRemoveTable.UseVisualStyleBackColor = true;
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // btnPlaceTable
            // 
            this.btnPlaceTable.Location = new System.Drawing.Point(3, 6);
            this.btnPlaceTable.Name = "btnPlaceTable";
            this.btnPlaceTable.Size = new System.Drawing.Size(92, 31);
            this.btnPlaceTable.TabIndex = 6;
            this.btnPlaceTable.Text = "Place table";
            this.btnPlaceTable.UseVisualStyleBackColor = true;
            this.btnPlaceTable.Click += new System.EventHandler(this.btnPlaceTable_Click);
            // 
            // btnCancelTable
            // 
            this.btnCancelTable.Location = new System.Drawing.Point(101, 6);
            this.btnCancelTable.Name = "btnCancelTable";
            this.btnCancelTable.Size = new System.Drawing.Size(92, 31);
            this.btnCancelTable.TabIndex = 8;
            this.btnCancelTable.Text = "Cancel table";
            this.btnCancelTable.UseVisualStyleBackColor = true;
            this.btnCancelTable.Click += new System.EventHandler(this.btnCancelTable_Click);
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            this.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.btnRemoveTable);
            this.SplitContainerMain.Panel1.Controls.Add(this.btnCancelTable);
            this.SplitContainerMain.Panel1.Controls.Add(this.btnPlaceTable);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.splitContainerTablesPreview);
            this.SplitContainerMain.Size = new System.Drawing.Size(1336, 667);
            this.SplitContainerMain.SplitterDistance = 37;
            this.SplitContainerMain.TabIndex = 9;
            // 
            // tableAddComponent
            // 
            this.tableAddComponent.Location = new System.Drawing.Point(3, 3);
            this.tableAddComponent.Name = "tableAddComponent";
            this.tableAddComponent.Padding = new System.Windows.Forms.Padding(2);
            this.tableAddComponent.Size = new System.Drawing.Size(190, 244);
            this.tableAddComponent.TabIndex = 0;
            this.tableAddComponent.TabStop = false;
            // 
            // ucrlTablesField
            // 
            this.ucrlTablesField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucrlTablesField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucrlTablesField.Location = new System.Drawing.Point(3, 3);
            this.ucrlTablesField.Name = "ucrlTablesField";
            this.ucrlTablesField.Size = new System.Drawing.Size(1405, 623);
            this.ucrlTablesField.TabIndex = 0;
            this.ucrlTablesField.Click += new System.EventHandler(this.ucrlTablesField_Click);
            // 
            // TablesPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SplitContainerMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TablesPreview";
            this.Size = new System.Drawing.Size(1336, 667);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewTableRecords;
        private System.Windows.Forms.TreeView treeViewTablesCatalog;
        private SplitContainer splitContainerTablesPreview;
        private SplitContainer splitContainer1;
        private Button btnPlaceTable;
        private Button btnRemoveTable;
        private PreviewComponents.TablesField ucrlTablesField;
        private SplitContainer splitContainer3;
        private Button btnSaveRow;
        private SplitContainer splitContainer4;
        private PreviewComponents.TableAddComponent tableAddComponent;
        private SplitContainer splitContainer2;
        private Button btnCancelTable;
        private SplitContainer SplitContainerMain;
    }
}
