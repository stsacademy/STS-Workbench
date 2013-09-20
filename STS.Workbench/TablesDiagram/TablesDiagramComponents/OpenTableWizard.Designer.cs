namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    partial class OpenTableWizard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenTableWizard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableInfo = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTableName = new System.Windows.Forms.TextBox();
            this.grdvTypes = new System.Windows.Forms.DataGridView();
            this.clmIsKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.grdvTypes);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(290, 212);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnOk);
            this.splitContainer2.Panel1.Controls.Add(this.tableInfo);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Size = new System.Drawing.Size(288, 40);
            this.splitContainer2.SplitterDistance = 41;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(-1, -1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(0, 0);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tableInfo
            // 
            this.tableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableInfo.Image = global::STS.Workbench.Properties.Resources.table_information;
            this.tableInfo.Location = new System.Drawing.Point(4, 4);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.Size = new System.Drawing.Size(33, 32);
            this.tableInfo.TabIndex = 0;
            this.tableInfo.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tbxTableName);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer3.Size = new System.Drawing.Size(237, 34);
            this.splitContainer3.SplitterDistance = 97;
            this.splitContainer3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table name:";
            // 
            // tbxTableName
            // 
            this.tbxTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTableName.Location = new System.Drawing.Point(8, 8);
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(120, 20);
            this.tbxTableName.TabIndex = 0;
            this.tbxTableName.Text = "table";
            // 
            // grdvTypes
            // 
            this.grdvTypes.AllowUserToOrderColumns = true;
            this.grdvTypes.AllowUserToResizeRows = false;
            this.grdvTypes.BackgroundColor = System.Drawing.Color.White;
            this.grdvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIsKey,
            this.clmDataType,
            this.columEmpty});
            this.grdvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdvTypes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdvTypes.Location = new System.Drawing.Point(3, 3);
            this.grdvTypes.Name = "grdvTypes";
            this.grdvTypes.Size = new System.Drawing.Size(282, 158);
            this.grdvTypes.TabIndex = 0;
            // 
            // clmIsKey
            // 
            this.clmIsKey.HeaderText = "Key";
            this.clmIsKey.MinimumWidth = 35;
            this.clmIsKey.Name = "clmIsKey";
            this.clmIsKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmIsKey.Width = 35;
            // 
            // clmDataType
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "empty row";
            this.clmDataType.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmDataType.HeaderText = "DataType";
            this.clmDataType.Items.AddRange(new object[] {
            "Boolean",
            "Char",
            "SByte",
            "Byte",
            "Int16",
            "UInt16",
            "Int32",
            "UInt32",
            "Int64",
            "UInt64",
            "Single",
            "Double",
            "Decimal",
            "DateTime",
            "String"});
            this.clmDataType.MinimumWidth = 50;
            this.clmDataType.Name = "clmDataType";
            this.clmDataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmDataType.ToolTipText = "Slot type";
            this.clmDataType.Width = 120;
            // 
            // columEmpty
            // 
            this.columEmpty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columEmpty.HeaderText = "";
            this.columEmpty.Name = "columEmpty";
            this.columEmpty.ReadOnly = true;
            this.columEmpty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(4, 4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer4.Panel2.Controls.Add(this.btnPlace);
            this.splitContainer4.Size = new System.Drawing.Size(290, 245);
            this.splitContainer4.SplitterDistance = 212;
            this.splitContainer4.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(207, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlace.Location = new System.Drawing.Point(126, 3);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // frmOpenTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 253);
            this.Controls.Add(this.splitContainer4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpenTable";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Open Table";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvTypes)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox tableInfo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTableName;
        private System.Windows.Forms.DataGridView grdvTypes;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsKey;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columEmpty;
    }
}