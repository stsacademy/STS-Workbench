using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    public partial class LoadingForm : Form
    {
        public volatile bool Stopped;

        public LoadingForm()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stopped = true;
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            Stopped = false;
        }
    }
}
