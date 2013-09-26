namespace STS.Workbench.HomeControls
{
    partial class DatabaseConnectionsControl
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
            this.lblDatabaseConnections = new System.Windows.Forms.Label();
            this.btnNewDatabaseConnections = new System.Windows.Forms.Button();
            this.btnEditConnections = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatabaseConnections
            // 
            this.lblDatabaseConnections.AutoSize = true;
            this.lblDatabaseConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseConnections.Location = new System.Drawing.Point(18, 14);
            this.lblDatabaseConnections.Name = "lblDatabaseConnections";
            this.lblDatabaseConnections.Size = new System.Drawing.Size(206, 25);
            this.lblDatabaseConnections.TabIndex = 0;
            this.lblDatabaseConnections.Text = "Database connections";
            // 
            // btnNewDatabaseConnections
            // 
            this.btnNewDatabaseConnections.BackgroundImage = global::STS.Workbench.Properties.Resources.PlusBtn;
            this.btnNewDatabaseConnections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewDatabaseConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDatabaseConnections.Location = new System.Drawing.Point(221, 13);
            this.btnNewDatabaseConnections.Name = "btnNewDatabaseConnections";
            this.btnNewDatabaseConnections.Size = new System.Drawing.Size(23, 23);
            this.btnNewDatabaseConnections.TabIndex = 1;
            this.btnNewDatabaseConnections.UseVisualStyleBackColor = true;
            // 
            // btnEditConnections
            // 
            this.btnEditConnections.BackgroundImage = global::STS.Workbench.Properties.Resources.WrenchBtn2;
            this.btnEditConnections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditConnections.Location = new System.Drawing.Point(247, 14);
            this.btnEditConnections.Name = "btnEditConnections";
            this.btnEditConnections.Size = new System.Drawing.Size(23, 23);
            this.btnEditConnections.TabIndex = 2;
            this.btnEditConnections.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::STS.Workbench.Properties.Resources.PlusBtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DatabaseConnectionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(199)))), ((int)(((byte)(222)))));
            this.Controls.Add(this.btnEditConnections);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewDatabaseConnections);
            this.Controls.Add(this.lblDatabaseConnections);
            this.Name = "DatabaseConnectionsControl";
            this.Size = new System.Drawing.Size(982, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatabaseConnections;
        private System.Windows.Forms.Button btnNewDatabaseConnections;
        private System.Windows.Forms.Button btnEditConnections;
        private System.Windows.Forms.Button button1;
    }
}
