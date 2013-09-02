namespace STS.Workbench.ServerControls
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
            this.ServerStatusIndicator.Location = new System.Drawing.Point(257, 14);
            this.ServerStatusIndicator.Name = "ServerStatusIndicator";
            this.ServerStatusIndicator.Size = new System.Drawing.Size(17, 14);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(176, 14);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(74, 13);
            this.Status.TabIndex = 1;
            this.Status.Text = "Server Status:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ServerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
