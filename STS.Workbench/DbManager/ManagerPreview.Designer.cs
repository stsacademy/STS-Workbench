namespace STS.Workbench.EngineManagers
{
    partial class ManagerPreview
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cbxDataBases = new System.Windows.Forms.ComboBox();
            this.btnAddDb = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.dbField = new STS.Workbench.PreviewComponents.TablesField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCloseTab);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 554);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cbxDataBases);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddDb);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Size = new System.Drawing.Size(1040, 511);
            this.splitContainer2.SplitterDistance = 31;
            this.splitContainer2.TabIndex = 0;
            // 
            // cbxDataBases
            // 
            this.cbxDataBases.DisplayMember = "STSdb4 Embaded";
            this.cbxDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataBases.FormattingEnabled = true;
            this.cbxDataBases.Items.AddRange(new object[] {
            "STSdb4 Embaded",
            "STSdb4 Client"});
            this.cbxDataBases.Location = new System.Drawing.Point(5, 3);
            this.cbxDataBases.Name = "cbxDataBases";
            this.cbxDataBases.Size = new System.Drawing.Size(130, 21);
            this.cbxDataBases.TabIndex = 1;
            // 
            // btnAddDb
            // 
            this.btnAddDb.Location = new System.Drawing.Point(141, 2);
            this.btnAddDb.Name = "btnAddDb";
            this.btnAddDb.Size = new System.Drawing.Size(75, 23);
            this.btnAddDb.TabIndex = 0;
            this.btnAddDb.Text = "Add";
            this.btnAddDb.UseVisualStyleBackColor = true;
            this.btnAddDb.Click += new System.EventHandler(this.btnAddDb_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(2, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dbField);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Size = new System.Drawing.Size(1036, 472);
            this.splitContainer3.SplitterDistance = 484;
            this.splitContainer3.TabIndex = 1;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTab.Location = new System.Drawing.Point(945, 3);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(92, 31);
            this.btnCloseTab.TabIndex = 11;
            this.btnCloseTab.Text = "Close tab";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            // 
            // tbxInfo
            // 
            this.tbxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInfo.Location = new System.Drawing.Point(0, 0);
            this.tbxInfo.Multiline = true;
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ReadOnly = true;
            this.tbxInfo.Size = new System.Drawing.Size(542, 436);
            this.tbxInfo.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(2, 2);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tbxInfo);
            this.splitContainer4.Size = new System.Drawing.Size(542, 466);
            this.splitContainer4.SplitterDistance = 26;
            this.splitContainer4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information:";
            // 
            // dbField
            // 
            this.dbField.AutoScroll = true;
            this.dbField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dbField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dbField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbField.Location = new System.Drawing.Point(0, 0);
            this.dbField.Name = "dbField";
            this.dbField.Size = new System.Drawing.Size(482, 470);
            this.dbField.TabIndex = 0;
            // 
            // ManagerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ManagerPreview";
            this.Size = new System.Drawing.Size(1040, 554);
            this.Click += new System.EventHandler(this.ManagerPreview_Click);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbxDataBases;
        private System.Windows.Forms.Button btnAddDb;
        private PreviewComponents.TablesField dbField;
        private System.Windows.Forms.SplitContainer splitContainer3;
        internal System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInfo;
    }
}
