using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.ChartWizard
{
    public partial class ChartTypeSelector : UserControl
    {
        private ToolStripButton LastCheckedButton = null;


        public ChartTypeSelector()
        {
            InitializeComponent();
        }

        private void toolButton_Click(object sender, EventArgs e)
        {

            if (LastCheckedButton != null)
                LastCheckedButton.Checked = false;

            var button = (ToolStripButton)sender;
            button.Checked = !button.Checked;

            LastCheckedButton = button;
        }
    }
}
