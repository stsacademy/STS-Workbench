namespace STS.Workbench.HomeControls
{
    partial class ModelControl
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
            this.lblModels = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxPlus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModels.Location = new System.Drawing.Point(18, 14);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(76, 25);
            this.lblModels.TabIndex = 0;
            this.lblModels.Text = "Models";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::STS.Workbench.Properties.Resources.folderOpen;
            this.pictureBox1.Location = new System.Drawing.Point(131, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxPlus
            // 
            this.picBoxPlus.Image = global::STS.Workbench.Properties.Resources.PlusBtn;
            this.picBoxPlus.Location = new System.Drawing.Point(100, 14);
            this.picBoxPlus.Name = "picBoxPlus";
            this.picBoxPlus.Size = new System.Drawing.Size(25, 24);
            this.picBoxPlus.TabIndex = 1;
            this.picBoxPlus.TabStop = false;
            // 
            // ModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxPlus);
            this.Controls.Add(this.lblModels);
            this.Name = "ModelControl";
            this.Size = new System.Drawing.Size(982, 218);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.PictureBox picBoxPlus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
