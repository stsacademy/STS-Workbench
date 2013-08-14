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
            System.Windows.Forms.DataGridView dataGridView2;
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelPlaceTable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTableName = new System.Windows.Forms.TextBox();
            this.Datatype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPlaceTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 405);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1189, 213);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(3, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(84, 23);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Add table";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(93, 3);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // panelPlaceTable
            // 
            this.panelPlaceTable.Controls.Add(dataGridView2);
            this.panelPlaceTable.Controls.Add(this.label1);
            this.panelPlaceTable.Controls.Add(this.tbxTableName);
            this.panelPlaceTable.Location = new System.Drawing.Point(3, 32);
            this.panelPlaceTable.Name = "panelPlaceTable";
            this.panelPlaceTable.Size = new System.Drawing.Size(370, 160);
            this.panelPlaceTable.TabIndex = 4;
            this.panelPlaceTable.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Table name:";
            // 
            // tbxTableName
            // 
            this.tbxTableName.Location = new System.Drawing.Point(75, 10);
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(100, 20);
            this.tbxTableName.TabIndex = 5;
            this.tbxTableName.Text = "table";
            // 
            // Datatype
            // 
            this.Datatype.HeaderText = "Datatype";
            this.Datatype.Name = "Datatype";
            this.Datatype.ReadOnly = true;
            this.Datatype.Width = 135;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Width = 30;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Datatype});
            dataGridView2.Location = new System.Drawing.Point(6, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new System.Drawing.Size(169, 115);
            dataGridView2.TabIndex = 6;
            // 
            // TablesPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPlaceTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.splitter1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "TablesPreview";
            this.Size = new System.Drawing.Size(1189, 618);
            this.Click += new System.EventHandler(this.TablesPreview_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPlaceTable.ResumeLayout(false);
            this.panelPlaceTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPlaceTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Key;
        private System.Windows.Forms.DataGridViewComboBoxColumn Datatype;
    }
}
