using STS.Workbench.TablesDiagram.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.DiagramPreviewComponents
{
    public partial class LoadingForm : Form
    {
        public volatile bool StopClicked = false;

        public Action Method { get; private set; }

        public static int x = 3;

        public LoadingForm()
            : this(null, ref x)
        {
        }

        public LoadingForm(Action method, ref int percents)
        {
            Method = method;

            InitializeComponent();
        }

        public void Start()
        {

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
    }
}
