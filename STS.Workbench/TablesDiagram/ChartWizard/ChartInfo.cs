using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.TablesDiagram.ChartWizard
{
    public class ChartInfo
    {
        public string SeriesName;
        public int Number;
        public bool IsChecked;

        public ChartInfo(string seriesName, int number, bool isChecked)
        {
            SeriesName = seriesName;
            Number = number;
            IsChecked = isChecked;
        }
    }
}
