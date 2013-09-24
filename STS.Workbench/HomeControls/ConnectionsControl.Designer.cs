namespace STS.Workbench.HomeControls
{
    partial class ConnectionsControl
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
            this.lblSTSdbConnections = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSTSdbConnections
            // 
            this.lblSTSdbConnections.AutoSize = true;
            this.lblSTSdbConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTSdbConnections.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSTSdbConnections.Location = new System.Drawing.Point(24, 24);
            this.lblSTSdbConnections.Name = "lblSTSdbConnections";
            this.lblSTSdbConnections.Size = new System.Drawing.Size(179, 24);
            this.lblSTSdbConnections.TabIndex = 0;
            this.lblSTSdbConnections.Text = "STSdb Connections";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STS.Workbench.Properties.Resources.WrenchBtn2;
            this.pictureBox2.Location = new System.Drawing.Point(241, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STS.Workbench.Properties.Resources.PlusBtn;
            this.pictureBox1.Location = new System.Drawing.Point(209, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ConnectionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSTSdbConnections);
            this.Name = "ConnectionsControl";
            this.Size = new System.Drawing.Size(924, 587);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSTSdbConnections;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
