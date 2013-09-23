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
    }
}
