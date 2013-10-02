namespace STS.Workbench.HomeControls
{
    partial class ServerInstanceControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStaticHost = new System.Windows.Forms.Label();
            this.lblStaticPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblStaticHost
            // 
            this.lblStaticHost.AutoSize = true;
            this.lblStaticHost.Location = new System.Drawing.Point(5, 44);
            this.lblStaticHost.Name = "lblStaticHost";
            this.lblStaticHost.Size = new System.Drawing.Size(32, 13);
            this.lblStaticHost.TabIndex = 1;
            this.lblStaticHost.Text = "Host:";
            // 
            // lblStaticPort
            // 
            this.lblStaticPort.AutoSize = true;
            this.lblStaticPort.Location = new System.Drawing.Point(5, 72);
            this.lblStaticPort.Name = "lblStaticPort";
            this.lblStaticPort.Size = new System.Drawing.Size(29, 13);
            this.lblStaticPort.TabIndex = 2;
            this.lblStaticPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(34, 44);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(88, 13);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "111.111.111.111";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(34, 72);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "1234";
            // 
            // ServerInstanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblStaticPort);
            this.Controls.Add(this.lblStaticHost);
            this.Controls.Add(this.lblName);
            this.Name = "ServerInstanceControl";
            this.Size = new System.Drawing.Size(178, 111);
            this.MouseLeave += new System.EventHandler(this.ServerInstanceControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ServerInstanceControl_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStaticHost;
        private System.Windows.Forms.Label lblStaticPort;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPort;

    }
}
