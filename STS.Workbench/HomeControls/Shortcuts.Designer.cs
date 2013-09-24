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
            this.lblShortcuts = new System.Windows.Forms.Label();
            this.lblSTSdbForums = new System.Windows.Forms.Label();
            this.lblSTSdbHomePage = new System.Windows.Forms.Label();
            this.picBoxHomePage = new System.Windows.Forms.PictureBox();
            this.picBoxForums = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForums)).BeginInit();
            this.SuspendLayout();
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
            this.lblSTSdbForums.MouseLeave += new System.EventHandler(this.lblSTSdbForums_MouseLeave);
            this.lblSTSdbForums.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSTSdbForums_MouseMove);
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
            this.lblSTSdbHomePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxHomePage_MouseDown);
            this.lblSTSdbHomePage.MouseLeave += new System.EventHandler(this.lblSTSdbHomePage_MouseLeave);
            this.lblSTSdbHomePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSTSdbHomePage_MouseMove);
            // 
            // picBoxHomePage
            // 
            this.picBoxHomePage.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxHomePage.Image = global::STS.Workbench.Properties.Resources.stsdbPic;
            this.picBoxHomePage.Location = new System.Drawing.Point(17, 80);
            this.picBoxHomePage.Name = "picBoxHomePage";
            this.picBoxHomePage.Size = new System.Drawing.Size(51, 49);
            this.picBoxHomePage.TabIndex = 4;
            this.picBoxHomePage.TabStop = false;
            this.picBoxHomePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxHomePage_MouseDown);
            this.picBoxHomePage.MouseLeave += new System.EventHandler(this.lblSTSdbHomePage_MouseLeave);
            this.picBoxHomePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSTSdbHomePage_MouseMove);
            // 
            // picBoxForums
            // 
            this.picBoxForums.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxForums.Image = global::STS.Workbench.Properties.Resources.forumPicture;
            this.picBoxForums.Location = new System.Drawing.Point(17, 159);
            this.picBoxForums.Name = "picBoxForums";
            this.picBoxForums.Size = new System.Drawing.Size(51, 49);
            this.picBoxForums.TabIndex = 0;
            this.picBoxForums.TabStop = false;
            this.picBoxForums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picBoxForums.MouseLeave += new System.EventHandler(this.lblSTSdbForums_MouseLeave);
            this.picBoxForums.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSTSdbForums_MouseMove);
            // 
            // Shortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.picBoxHomePage);
            this.Controls.Add(this.lblSTSdbHomePage);
            this.Controls.Add(this.lblSTSdbForums);
            this.Controls.Add(this.lblShortcuts);
            this.Controls.Add(this.picBoxForums);
            this.Name = "Shortcuts";
            this.Size = new System.Drawing.Size(229, 640);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxForums;
        private System.Windows.Forms.Label lblShortcuts;
        private System.Windows.Forms.Label lblSTSdbForums;
        private System.Windows.Forms.Label lblSTSdbHomePage;
        private System.Windows.Forms.PictureBox picBoxHomePage;
    }
}
