namespace STS.Workbench.ServerControls
{
    partial class ConnectionList
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
            this.ConnectionLB = new System.Windows.Forms.ListBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ConnectionLB
            // 
            this.ConnectionLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionLB.FormattingEnabled = true;
            this.ConnectionLB.Location = new System.Drawing.Point(0, 0);
            this.ConnectionLB.Name = "ConnectionLB";
            this.ConnectionLB.Size = new System.Drawing.Size(355, 152);
            this.ConnectionLB.TabIndex = 0;
            // 
            // Disconnect
            // 
            this.Disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Disconnect.Location = new System.Drawing.Point(280, 159);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConnectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.ConnectionLB);
            this.Name = "ConnectionList";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Size = new System.Drawing.Size(355, 182);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ConnectionLB;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Timer timer1;
    }
}
