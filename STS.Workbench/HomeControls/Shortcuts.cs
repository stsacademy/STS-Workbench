using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.HomeControls
{
    public partial class Shortcuts : UserControl
    {
        public Shortcuts()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://stsdb.com/forum/forum.html");
            }
            catch { }
        }

        private void picBoxHomePage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://stsdb.com/");
            }
            catch { }
        }

        private void lblSTSdbHomePage_MouseMove(object sender, MouseEventArgs e)
        {
            lblSTSdbHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F,
                                                                      System.Drawing.FontStyle.Underline,
                                                                      System.Drawing.GraphicsUnit.Point, ((byte)(0)));       
       }

        private void lblSTSdbHomePage_MouseLeave(object sender, EventArgs e)
        {
            lblSTSdbHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F,
                                                                     System.Drawing.FontStyle.Regular,
                                                                     System.Drawing.GraphicsUnit.Point, ((byte)(0)));   
        }

        private void lblSTSdbForums_MouseMove(object sender, MouseEventArgs e)
        {
            lblSTSdbForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F,
                                                                     System.Drawing.FontStyle.Underline,
                                                                     System.Drawing.GraphicsUnit.Point, ((byte)(0)));   
        }

        private void lblSTSdbForums_MouseLeave(object sender, EventArgs e)
        {
            lblSTSdbForums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.68F,
                                                              System.Drawing.FontStyle.Regular,
                                                              System.Drawing.GraphicsUnit.Point, ((byte)(0)));   
        }
    }
}
