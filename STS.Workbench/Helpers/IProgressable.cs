using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Helpers
{
    public interface IProgressable
    {
        void Stop();
        int Percents { get; }
    }
}