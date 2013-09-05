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
            this.dbField = new STS.Workbench.PreviewComponents.TablesField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 554);
            this.splitContainer1.SplitterDistance = 134;
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
            this.splitContainer2.Size = new System.Drawing.Size(902, 554);
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
            this.cbxDataBases.Location = new System.Drawing.Point(86, 3);
            this.cbxDataBases.Name = "cbxDataBases";
            this.cbxDataBases.Size = new System.Drawing.Size(130, 21);
            this.cbxDataBases.TabIndex = 1;
            // 
            // btnAddDb
            // 
            this.btnAddDb.Location = new System.Drawing.Point(5, 3);
            this.btnAddDb.Name = "btnAddDb";
            this.btnAddDb.Size = new System.Drawing.Size(75, 23);
            this.btnAddDb.TabIndex = 0;
            this.btnAddDb.Text = "Add db";
            this.btnAddDb.UseVisualStyleBackColor = true;
            this.btnAddDb.Click += new System.EventHandler(this.btnAddDb_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(2, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dbField);
            this.splitContainer3.Size = new System.Drawing.Size(898, 515);
            this.splitContainer3.SplitterDistance = 387;
            this.splitContainer3.TabIndex = 1;
            // 
            // dbField
            // 
            this.dbField.AutoScroll = true;
            this.dbField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dbField.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dbField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbField.Location = new System.Drawing.Point(0, 0);
            this.dbField.Name = "dbField";
            this.dbField.Size = new System.Drawing.Size(385, 513);
            this.dbField.TabIndex = 0;
            // 
            // ManagerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ManagerPreview";
            this.Size = new System.Drawing.Size(1040, 554);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbxDataBases;
        private System.Windows.Forms.Button btnAddDb;
        private PreviewComponents.TablesField dbField;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}
