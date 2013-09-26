using STS.Workbench.PreviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public static class TablesTransfer
    {
        private static ITable Table = null;

        public static bool HavePaste
        {
            get { return Table != null; }
        }

        public static void Copy(ITable table)
        {
            Table = table;
        }

        public static ITable Paste()
        {
            var table = Table;
            Table = null;

            return table;
        }
    }
}
