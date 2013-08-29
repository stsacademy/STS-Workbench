﻿using System.Windows.Forms;
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("myDb");
            this.grdViewTableRecords = new System.Windows.Forms.DataGridView();
            this.treeViewTablesCatalog = new System.Windows.Forms.TreeView();
            this.splitContainerTablesPreview = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.tbxErrors = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnSaveRow = new System.Windows.Forms.Button();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.btnPlaceTable = new System.Windows.Forms.Button();
            this.btnCancelTable = new System.Windows.Forms.Button();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnCommit = new System.Windows.Forms.Button();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableAddComponent = new STS.Workbench.PreviewComponents.TableAddComponent();
            this.ucrlTablesField = new STS.Workbench.PreviewComponents.TablesField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdViewTableRecords
            // 
            this.grdViewTableRecords.AllowUserToDeleteRows = false;
            this.grdViewTableRecords.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdViewTableRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewTableRecords.ColumnHeadersVisible = false;
            this.grdViewTableRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewTableRecords.Location = new System.Drawing.Point(0, 0);
            this.grdViewTableRecords.Name = "grdViewTableRecords";
            this.grdViewTableRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdViewTableRecords.Size = new System.Drawing.Size(1085, 109);
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
            this.treeViewTablesCatalog.Size = new System.Drawing.Size(193, 135);
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
            this.splitContainerTablesPreview.Size = new System.Drawing.Size(1296, 591);
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
            this.splitContainer4.Size = new System.Drawing.Size(203, 591);
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
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(203, 330);
            this.splitContainer2.SplitterDistance = 145;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnClearLog);
            this.splitContainer5.Panel1.Controls.Add(this.lblLog);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tbxErrors);
            this.splitContainer5.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer5.Size = new System.Drawing.Size(199, 177);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 1;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(131, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(65, 22);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearErrors_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(0, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Padding = new System.Windows.Forms.Padding(5);
            this.lblLog.Size = new System.Drawing.Size(38, 23);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Log:";
            // 
            // tbxErrors
            // 
            this.tbxErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxErrors.Location = new System.Drawing.Point(2, 2);
            this.tbxErrors.Multiline = true;
            this.tbxErrors.Name = "tbxErrors";
            this.tbxErrors.ReadOnly = true;
            this.tbxErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxErrors.Size = new System.Drawing.Size(195, 144);
            this.tbxErrors.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.ucrlTablesField);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 591);
            this.splitContainer1.SplitterDistance = 407;
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
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.btnDiscard);
            this.splitContainer3.Panel1.Controls.Add(this.btnExport);
            this.splitContainer3.Panel1.Controls.Add(this.btnImport);
            this.splitContainer3.Panel1.Controls.Add(this.btnDeleteRow);
            this.splitContainer3.Panel1.Controls.Add(this.btnSaveRow);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grdViewTableRecords);
            this.splitContainer3.Size = new System.Drawing.Size(1089, 146);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 4;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(489, 2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(203, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(122, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImportCsv_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(38, 2);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRow.TabIndex = 1;
            this.btnDeleteRow.Text = "Delete row";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnSaveRow
            // 
            this.btnSaveRow.Location = new System.Drawing.Point(408, 2);
            this.btnSaveRow.Name = "btnSaveRow";
            this.btnSaveRow.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRow.TabIndex = 0;
            this.btnSaveRow.Text = "Save";
            this.btnSaveRow.UseVisualStyleBackColor = true;
            this.btnSaveRow.Click += new System.EventHandler(this.btnSaveRow_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.Location = new System.Drawing.Point(216, 6);
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
            this.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainerMain.IsSplitterFixed = true;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            this.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.btnCommit);
            this.SplitContainerMain.Panel1.Controls.Add(this.btnRemoveTable);
            this.SplitContainerMain.Panel1.Controls.Add(this.btnCancelTable);
            this.SplitContainerMain.Panel1.Controls.Add(this.btnPlaceTable);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.splitContainerTablesPreview);
            this.SplitContainerMain.Size = new System.Drawing.Size(1296, 632);
            this.SplitContainerMain.SplitterDistance = 37;
            this.SplitContainerMain.TabIndex = 9;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(314, 6);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(92, 31);
            this.btnCommit.TabIndex = 9;
            this.btnCommit.Text = "Commit Db";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer6.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer6.Size = new System.Drawing.Size(1089, 180);
            this.splitContainer6.SplitterDistance = 146;
            this.splitContainer6.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1081, 22);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 0;
            // 
            // tableAddComponent
            // 
            this.tableAddComponent.Location = new System.Drawing.Point(3, 3);
            this.tableAddComponent.Name = "tableAddComponent";
            this.tableAddComponent.Padding = new System.Windows.Forms.Padding(2);
            this.tableAddComponent.Size = new System.Drawing.Size(190, 247);
            this.tableAddComponent.TabIndex = 0;
            this.tableAddComponent.TabStop = false;
            // 
            // ucrlTablesField
            // 
            this.ucrlTablesField.AutoScroll = true;
            this.ucrlTablesField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucrlTablesField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucrlTablesField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucrlTablesField.Location = new System.Drawing.Point(2, 2);
            this.ucrlTablesField.Name = "ucrlTablesField";
            this.ucrlTablesField.Size = new System.Drawing.Size(1081, 399);
            this.ucrlTablesField.TabIndex = 0;
            this.ucrlTablesField.Click += new System.EventHandler(this.ucrlTablesField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Changes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit:";
            // 
            // TablesPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SplitContainerMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "TablesPreview";
            this.Size = new System.Drawing.Size(1296, 632);
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
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
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
        private SplitContainer splitContainer5;
        private Label lblLog;
        private TextBox tbxErrors;
        private Button btnExport;
        private Button btnImport;
        private Button btnDeleteRow;
        private Button btnClearLog;
        private Button btnDiscard;
        private Button btnCommit;
        private SplitContainer splitContainer6;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label1;
    }
}
