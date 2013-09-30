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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grdViewSeriesSet = new System.Windows.Forms.DataGridView();
            this.isShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chrtSelected = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSeriesSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer2.Panel2.Controls.Add(this.chrtSelected);
            this.splitContainer2.Size = new System.Drawing.Size(532, 241);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 0;
            // 
            // chrtSelected
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtSelected.ChartAreas.Add(chartArea1);
            this.chrtSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrtSelected.Legends.Add(legend1);
            this.chrtSelected.Location = new System.Drawing.Point(0, 0);
            this.chrtSelected.Name = "chrtSelected";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtSelected.Series.Add(series1);
            this.chrtSelected.Size = new System.Drawing.Size(320, 239);
            this.chrtSelected.TabIndex = 0;
            this.chrtSelected.Text = "chart1";
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

    }
}
