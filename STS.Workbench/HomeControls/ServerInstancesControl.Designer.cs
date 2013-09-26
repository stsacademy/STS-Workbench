namespace STS.Workbench.HomeControls
{
    partial class ServerInstancesControl
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
            this.lblServerInstances = new System.Windows.Forms.Label();
            this.btnNewServerInstances = new System.Windows.Forms.Button();
            this.btnEditServerInstances = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServerInstances
            // 
            this.lblServerInstances.AutoSize = true;
            this.lblServerInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerInstances.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServerInstances.Location = new System.Drawing.Point(27, 29);
            this.lblServerInstances.Name = "lblServerInstances";
            this.lblServerInstances.Size = new System.Drawing.Size(149, 24);
            this.lblServerInstances.TabIndex = 0;
            this.lblServerInstances.Text = "Server instances";
            // 
            // btnNewServerInstances
            // 
            this.btnNewServerInstances.BackgroundImage = global::STS.Workbench.Properties.Resources.PlusBtn;
            this.btnNewServerInstances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewServerInstances.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewServerInstances.Location = new System.Drawing.Point(178, 29);
            this.btnNewServerInstances.Name = "btnNewServerInstances";
            this.btnNewServerInstances.Size = new System.Drawing.Size(23, 23);
            this.btnNewServerInstances.TabIndex = 2;
            this.btnNewServerInstances.UseVisualStyleBackColor = true;
            // 
            // btnEditServerInstances
            // 
            this.btnEditServerInstances.BackgroundImage = global::STS.Workbench.Properties.Resources.WrenchBtn2;
            this.btnEditServerInstances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditServerInstances.Location = new System.Drawing.Point(207, 29);
            this.btnEditServerInstances.Name = "btnEditServerInstances";
            this.btnEditServerInstances.Size = new System.Drawing.Size(23, 23);
            this.btnEditServerInstances.TabIndex = 3;
            this.btnEditServerInstances.UseVisualStyleBackColor = true;
            // 
            // ServerInstancesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.btnEditServerInstances);
            this.Controls.Add(this.btnNewServerInstances);
            this.Controls.Add(this.lblServerInstances);
            this.Name = "ServerInstancesControl";
            this.Size = new System.Drawing.Size(924, 587);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerInstances;
        private System.Windows.Forms.Button btnNewServerInstances;
        private System.Windows.Forms.Button btnEditServerInstances;
    }
}
