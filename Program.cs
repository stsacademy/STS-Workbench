using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //asdasdasd

            List<Schema_Table.Column> list = new List<Schema_Table.Column>();
             
            list.Add(new Schema_Table.Column("FirstName", DataType.String, false));
            list.Add(new Schema_Table.Column("MiddleName", DataType.String, false));
            list.Add(new Schema_Table.Column("FAQ", DataType.Int32, true));
            list.Add(new Schema_Table.Column("LastName", DataType.String, false));
            list.Add(new Schema_Table.Column("ID", DataType.Int64, true));

            Schema_Table.SchemaTable schTable = new Schema_Table.SchemaTable("mydatabase", true, "D:\\TestSchema");

            schTable.CreateTable("Table", list.ToArray());

            schTable.AddEntry("Table", new object[] { "a", "b", "c" });
        }
    }
}
