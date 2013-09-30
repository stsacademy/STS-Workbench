namespace STS.Workbench.TablesDiagram.ChartWizard
{
    partial class ChartSeriesSelector
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grdViewSeriesSet = new System.Windows.Forms.DataGridView();
            this.isShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chrtSelected = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnViewChanges = new System.Windows.Forms.Button();
            this.cmbRecords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSeriesSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewSeriesSet
            // 
            this.grdViewSeriesSet.AllowUserToAddRows = false;
            this.grdViewSeriesSet.AllowUserToDeleteRows = false;
            this.grdViewSeriesSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewSeriesSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isShow,
            this.series,
            this.type});
            this.grdViewSeriesSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewSeriesSet.Location = new System.Drawing.Point(0, 0);
            this.grdViewSeriesSet.Name = "grdViewSeriesSet";
            this.grdViewSeriesSet.Size = new System.Drawing.Size(530, 186);
            this.grdViewSeriesSet.TabIndex = 0;
            // 
            // isShow
            // 
            this.isShow.HeaderText = "Show";
            this.isShow.Name = "isShow";
            this.isShow.Width = 40;
            // 
            // series
            // 
            this.series.HeaderText = "Series name";
            this.series.Name = "series";
            // 
            // type
            // 
            this.type.HeaderText = "Colum type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Panel2.Controls.Add(this.grdViewSeriesSet);
            this.splitContainer1.Size = new System.Drawing.Size(532, 433);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(532, 241);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chrtSelected);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cmbRecords);
            this.splitContainer3.Panel2.Controls.Add(this.btnViewChanges);
            this.splitContainer3.Size = new System.Drawing.Size(321, 239);
            this.splitContainer3.SplitterDistance = 205;
            this.splitContainer3.TabIndex = 1;
            // 
            // chrtSelected
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtSelected.ChartAreas.Add(chartArea2);
            this.chrtSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrtSelected.Legends.Add(legend2);
            this.chrtSelected.Location = new System.Drawing.Point(0, 0);
            this.chrtSelected.Name = "chrtSelected";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtSelected.Series.Add(series2);
            this.chrtSelected.Size = new System.Drawing.Size(321, 205);
            this.chrtSelected.TabIndex = 0;
            this.chrtSelected.Text = "chart1";
            // 
            // btnViewChanges
            // 
            this.btnViewChanges.Location = new System.Drawing.Point(3, 4);
            this.btnViewChanges.Name = "btnViewChanges";
            this.btnViewChanges.Size = new System.Drawing.Size(75, 23);
            this.btnViewChanges.TabIndex = 0;
            this.btnViewChanges.Text = "Refresh";
            this.btnViewChanges.UseVisualStyleBackColor = true;
            this.btnViewChanges.Click += new System.EventHandler(this.btnRefreshChanges_Click);
            // 
            // cmbRecords
            // 
            this.cmbRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecords.FormattingEnabled = true;
            this.cmbRecords.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cmbRecords.Location = new System.Drawing.Point(197, 6);
            this.cmbRecords.Name = "cmbRecords";
            this.cmbRecords.Size = new System.Drawing.Size(121, 21);
            this.cmbRecords.TabIndex = 1;
            // 
            // ChartSeriesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChartSeriesSelector";
            this.Size = new System.Drawing.Size(532, 433);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSeriesSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewSeriesSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSelected;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btnViewChanges;
        private System.Windows.Forms.ComboBox cmbRecords;

    }
}
