using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench
{
    public static class FormExtensions
    {
        public static KeyValuePair<object[], object[]> GetKeyValue(this DataGridViewRow row, int keyCount, int recCount)
        {
            object[] key = new object[keyCount];
            object[] rec = new object[recCount];

            for (int i = 0; i < keyCount; i++)
                key[i] = row.Cells[i].Value;

            for (int i = keyCount; i < keyCount + recCount; i++)
                rec[i - keyCount] = row.Cells[i].Value;

            return new KeyValuePair<object[], object[]>(key, rec);
        }

        public static Control FindControlByName(this Control control, string name)
        {
            foreach (var cntrl in control.Controls)
            {
                if (((Control)cntrl).Name == name)
                    return (Control)cntrl;
            }

            return null;
        }

        public static bool ContainsControlByInstance(this Control instance, Control control)
        {
            foreach (var item in instance.Controls)
            {
                var cntrl = (Control)item;

                if (cntrl.ContainsControlByInstance(control))
                    return true;

                if (cntrl.Controls.Contains(control))
                    return true;
            }

            return false;
        }

        public static void SetChildBackColor(this TreeNode instance, Color color)
        {
            foreach (var node in instance.Nodes)
                ((TreeNode)node).BackColor = color;
        }
    }
}