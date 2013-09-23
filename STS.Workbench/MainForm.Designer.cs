using System.Windows.Forms;
namespace STS.Workbench
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userControls = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.btnWizarDbTest = new System.Windows.Forms.Button();
            this.btnControlTest = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnTablesTest = new System.Windows.Forms.Button();
            this.imgListControls = new System.Windows.Forms.ImageList(this.components);
            this.btnHomeTest = new System.Windows.Forms.Button();
            this.userControls.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControls
            // 
            this.userControls.Controls.Add(this.HomePage);
            this.userControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControls.ImageList = this.imgListControls;
            this.userControls.Location = new System.Drawing.Point(0, 0);
            this.userControls.Name = "userControls";
            this.userControls.SelectedIndex = 0;
            this.userControls.Size = new System.Drawing.Size(1339, 565);
            this.userControls.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.btnHomeTest);
            this.HomePage.Controls.Add(this.btnWizarDbTest);
            this.HomePage.Controls.Add(this.btnControlTest);
            this.HomePage.Controls.Add(this.btnServer);
            this.HomePage.Controls.Add(this.btnTablesTest);
            this.HomePage.ImageKey = "home-12.ico";
            this.HomePage.Location = new System.Drawing.Point(4, 23);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1331, 538);
            this.HomePage.TabIndex = 1;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // btnWizarDbTest
            // 
            this.btnWizarDbTest.Location = new System.Drawing.Point(93, 167);
            this.btnWizarDbTest.Name = "btnWizarDbTest";
            this.btnWizarDbTest.Size = new System.Drawing.Size(101, 23);
            this.btnWizarDbTest.TabIndex = 3;
            this.btnWizarDbTest.Text = "Wizard db";
            this.btnWizarDbTest.UseVisualStyleBackColor = true;
            this.btnWizarDbTest.Click += new System.EventHandler(this.btnWizarDbTest_Click);
            // 
            // btnControlTest
            // 
            this.btnControlTest.Location = new System.Drawing.Point(93, 138);
            this.btnControlTest.Name = "btnControlTest";
            this.btnControlTest.Size = new System.Drawing.Size(101, 23);
            this.btnControlTest.TabIndex = 2;
            this.btnControlTest.Text = "DB manager test";
            this.btnControlTest.UseVisualStyleBackColor = true;
            this.btnControlTest.Click += new System.EventHandler(this.btnControlTest_Click);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(93, 109);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(101, 23);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "Servers Test";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnTablesTest
            // 
            this.btnTablesTest.Location = new System.Drawing.Point(93, 80);
            this.btnTablesTest.Name = "btnTablesTest";
            this.btnTablesTest.Size = new System.Drawing.Size(101, 23);
            this.btnTablesTest.TabIndex = 0;
            this.btnTablesTest.Text = "TablesTest";
            this.btnTablesTest.UseVisualStyleBackColor = true;
            this.btnTablesTest.Click += new System.EventHandler(this.btnTablesTest_Click);
            // 
            // imgListControls
            // 
            this.imgListControls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListControls.ImageStream")));
            this.imgListControls.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListControls.Images.SetKeyName(0, "home-12.ico");
            // 
            // btnHomeTest
            // 
            this.btnHomeTest.Location = new System.Drawing.Point(93, 196);
            this.btnHomeTest.Name = "btnHomeTest";
            this.btnHomeTest.Size = new System.Drawing.Size(101, 23);
            this.btnHomeTest.TabIndex = 4;
            this.btnHomeTest.Text = "Home Test";
            this.btnHomeTest.UseVisualStyleBackColor = true;
            this.btnHomeTest.Click += new System.EventHandler(this.btnHomeTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 565);
            this.Controls.Add(this.userControls);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.userControls.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl userControls;
        private TabPage HomePage;
        private Button btnServer;
        private Button btnTablesTest;
        private ImageList imgListControls;
        private Button btnControlTest;
        private Button btnWizarDbTest;
        private Button btnHomeTest;
    }
}

