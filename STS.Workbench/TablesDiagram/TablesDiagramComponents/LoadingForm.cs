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
        public volatile bool StopClicked;

        public LoadingForm()
        {
            InitializeComponent();
        }
        
        public void SetPercents(int value)
        {
            progressBar1.Value = value;
        }

        public void ChangeProgressBarStyle(ProgressBarStyle style)
        {
            progressBar1.Style = style;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopClicked = true;
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            StopClicked = false;
        }
    }
}
