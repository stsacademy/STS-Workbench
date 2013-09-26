using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.TablesDiagram.TablesDiagramComponents
{
    public partial class PropertyForm : Form
    {
        public PropertyForm(Control control)
        {
            InitializeComponent();
            Text = control.Name;
            pGrid.SelectedObject = control;
            SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
        }

        private void PropertyForm_Shown(object sender, EventArgs e)
        {
            Location = Cursor.Position;
        }
    }
}
