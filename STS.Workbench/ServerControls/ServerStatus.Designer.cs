﻿namespace STS.Workbench.ServerControls
{
    partial class ServerStatus
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ServerStatusIndicator = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Host = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.CPUUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ServerStatusIndicator});
            this.shapeContainer1.Size = new System.Drawing.Size(295, 258);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ServerStatusIndicator
            // 
            this.ServerStatusIndicator.BackColor = System.Drawing.SystemColors.Control;
            this.ServerStatusIndicator.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ServerStatusIndicator.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ServerStatusIndicator.FillGradientColor = System.Drawing.Color.Linen;
            this.ServerStatusIndicator.Location = new System.Drawing.Point(78, 1);
            this.ServerStatusIndicator.Name = "ServerStatusIndicator";
            this.ServerStatusIndicator.Size = new System.Drawing.Size(18, 12);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(3, 1);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(74, 13);
            this.Status.TabIndex = 1;
            this.Status.Text = "Server Status:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(3, 22);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(32, 13);
            this.Host.TabIndex = 2;
            this.Host.Text = "Host:";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(3, 44);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(29, 13);
            this.Port.TabIndex = 3;
            this.Port.Text = "Port:";
            // 
            // CPUUsage
            // 
            this.CPUUsage.AutoSize = true;
            this.CPUUsage.Location = new System.Drawing.Point(3, 66);
            this.CPUUsage.Name = "CPUUsage";
            this.CPUUsage.Size = new System.Drawing.Size(66, 13);
            this.CPUUsage.TabIndex = 4;
            this.CPUUsage.Text = "CPU Usage:";
            // 
            // ServerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CPUUsage);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ServerStatus";
            this.Size = new System.Drawing.Size(295, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ServerStatusIndicator;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label CPUUsage;
    }
}
