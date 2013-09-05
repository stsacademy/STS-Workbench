using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.DbManager.DataBases
{
    public interface IDataBase
    {
        string Name { get; }
        IConnection DbConnection { get; }

        bool IsReady { get; }
        void Open();
    }
}
