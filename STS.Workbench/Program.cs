using STSdb4.Data;
using STSdb4.Database;
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
            List<Schema.Column> columns = new List<Schema.Column>();

            columns.Add(new Schema.Column("Column1", DataType.Int32, true));
            columns.Add(new Schema.Column("Column2", DataType.String, false));

            Schema.SchemaTable tab = new Schema.SchemaTable("MyDatabase", false, "MyPath");

            var index = tab.CreateTable("MyTable", columns.ToArray());

            index.AddRow(new Schema.Row(1, new object[] { 8, "Gosho" }));

            using (IStorageEngine engine = STSdb.FromFile("stsdb4.sys", "stsdb4.dat"))
            {
                IIndex<int, string> table = engine.OpenXIndex<int, string>("table");

                for (int i = 0; i < 1000000; i++)
                {
                    table[i] = i.ToString();
                }

                table.Flush();
                engine.Commit();
            }


            STS_Data_Adapter.STSConnection connection = new STS_Data_Adapter.STSConnection(@"Provider=STSDb.4.0;System Source=D:\stsdb4.sys;Data Source=D:\stsdb4.dat");

            connection.Open();
            connection.State.ToString();

            connection.Close();
            connection.State.ToString();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
