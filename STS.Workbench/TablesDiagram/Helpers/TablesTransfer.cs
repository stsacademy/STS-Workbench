using STS.Workbench.PreviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public static class CopyPaste<T>
    {
        private static T[] Tables = null;

        public static bool HavePaste
        {
            get { return Tables != null && Tables.Length > 0; }
        }

        public static void Copy(params T[] items)
        {
            Tables = items;
        }

        public static T[] Paste()
        {
            var table = Tables;
            Tables = null;

            return table;
        }
    }

    public static class TablesTransfer
    {
        private static ITable[] Tables = null;

        public static bool HavePaste
        {
            get { return CopyPaste<ITable>.HavePaste; }
        }

        public static void Copy(params ITable[] tables)
        {
            CopyPaste<ITable>.Copy(tables);
        }

        public static ITable[] Paste()
        {
            return CopyPaste<ITable>.Paste();
        }
    }
}
