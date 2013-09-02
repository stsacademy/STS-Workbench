using System;
using System.Collections.Generic;
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
            return control.FindControlByName(name, ControlType.All);
        }

        public static Control FindControlByName(this Control control, string name, ControlType controlType)
        {
            switch (controlType)
            {
                case ControlType.All:
                    {
                        foreach (var cntrl in control.Controls)
                        {
                            if (((Control)cntrl).Name == name)
                                return (Control)cntrl;
                        }
                    }
                    break;
                case ControlType.UserControl:
                    {
                        foreach (var cntrl in control.Controls)
                        {
                            if (((Control)cntrl).Name == name || cntrl.GetType() == typeof(UserControl))
                                return (Control)cntrl;
                        }
                    }
                    break;
                default:
                    break;
            }

            return null;
        }
    }

    public enum ControlType
    {
        All = 0,
        UserControl = 1,
        //TODO all.
    }
}