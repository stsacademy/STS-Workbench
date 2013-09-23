namespace STS.Workbench.HomeControls
{
    partial class Shortcuts
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblShortcuts = new System.Windows.Forms.Label();
            this.lblSTSdbForums = new System.Windows.Forms.Label();
            this.lblSTSdbHomePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::STS.Workbench.Properties.Resources.forumPicture;
            this.pictureBox1.Location = new System.Drawing.Point(17, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblShortcuts
            // 
            this.lblShortcuts.AutoSize = true;
            this.lblShortcuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortcuts.Location = new System.Drawing.Point(33, 11);
            this.lblShortcuts.Name = "lblShortcuts";
            this.lblShortcuts.Size = new System.Drawing.Size(135, 32);
            this.lblShortcuts.TabIndex = 1;
            this.lblShortcuts.Text = "Shortcuts";
            // 
            // lblSTSdbForums
            // 
            this.lblSTSdbForums.AutoSize = true;
            this.lblSTSdbForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTSdbForums.Location = new System.Drawing.Point(74, 171);
            this.lblSTSdbForums.Name = "lblSTSdbForums";
            this.lblSTSdbForums.Size = new System.Drawing.Size(109, 18);
            this.lblSTSdbForums.TabIndex = 2;
            this.lblSTSdbForums.Text = "STSdb Forums";
            this.lblSTSdbForums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // lblSTSdbHomePage
            // 
            this.lblSTSdbHomePage.AutoSize = true;
            this.lblSTSdbHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTSdbHomePage.Location = new System.Drawing.Point(74, 90);
            this.lblSTSdbHomePage.Name = "lblSTSdbHomePage";
            this.lblSTSdbHomePage.Size = new System.Drawing.Size(136, 18);
            this.lblSTSdbHomePage.TabIndex = 3;
            this.lblSTSdbHomePage.Text = "STSdb Home Page";
            // 
            // Shortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lblSTSdbHomePage);
            this.Controls.Add(this.lblSTSdbForums);
            this.Controls.Add(this.lblShortcuts);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Shortcuts";
            this.Size = new System.Drawing.Size(229, 640);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblShortcuts;
        private System.Windows.Forms.Label lblSTSdbForums;
        private System.Windows.Forms.Label lblSTSdbHomePage;
    }
}
