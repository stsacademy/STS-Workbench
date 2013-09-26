﻿namespace STS.Workbench.HomeControls
{
    partial class Home
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
            this.ServerInstancesControl = new STS.Workbench.HomeControls.ServerInstancesControl();
            this.modelControl1 = new STS.Workbench.HomeControls.DatabaseConnectionsControl();
            this.shortcuts1 = new STS.Workbench.HomeControls.Shortcuts();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 800;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.shortcuts1);
            this.splitContainer1.Panel2MinSize = 209;
            this.splitContainer1.Size = new System.Drawing.Size(1013, 649);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.splitContainer2.Panel1.Controls.Add(this.ServerInstancesControl);
            this.splitContainer2.Panel1MinSize = 250;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.splitContainer2.Panel2.Controls.Add(this.modelControl1);
            this.splitContainer2.Panel2MinSize = 250;
            this.splitContainer2.Size = new System.Drawing.Size(800, 649);
            this.splitContainer2.SplitterDistance = 477;
            this.splitContainer2.TabIndex = 0;
            // 
            // ServerInstancesControl
            // 
            this.ServerInstancesControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.ServerInstancesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerInstancesControl.Location = new System.Drawing.Point(0, 0);
            this.ServerInstancesControl.Name = "ServerInstancesControl";
            this.ServerInstancesControl.Size = new System.Drawing.Size(800, 477);
            this.ServerInstancesControl.TabIndex = 0;
            // 
            // modelControl1
            // 
            this.modelControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.modelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelControl1.Location = new System.Drawing.Point(0, 0);
            this.modelControl1.Name = "modelControl1";
            this.modelControl1.Size = new System.Drawing.Size(800, 250);
            this.modelControl1.TabIndex = 0;
            // 
            // shortcuts1
            // 
            this.shortcuts1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.shortcuts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortcuts1.Location = new System.Drawing.Point(0, 0);
            this.shortcuts1.Name = "shortcuts1";
            this.shortcuts1.Size = new System.Drawing.Size(209, 649);
            this.shortcuts1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1013, 649);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Shortcuts shortcuts1;
        private DatabaseConnectionsControl modelControl1;
        private ServerInstancesControl ServerInstancesControl;

    }
}
