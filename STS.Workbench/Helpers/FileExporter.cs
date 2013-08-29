using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Helpers
{
    public class FileExporter
    {
        public string FilePath { get; private set; }
        public string Delimiter { get; private set; }

        public FileExporter(string filePath)
        {
            FilePath = filePath;
            Delimiter = ";";
        }

        public void Export(IEnumerable<KeyValuePair<object[], object[]>> data)
        {
            using (FileStream stream = new FileStream(FilePath, FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(stream);

                foreach (var kv in data)
                {
                    StringBuilder builder = new StringBuilder();

                    foreach (var item in kv.Key)
                    {
                        builder.Append(item);
                        builder.Append(Delimiter);
                    }

                    foreach (var item in kv.Value)
                    {
                        builder.Append(item);
                        builder.Append(Delimiter);
                    }
                    builder.Remove(builder.Length - 1, 1);

                    writer.WriteLine(builder.ToString());
                }

                writer.Flush();
            }
        }
    }
}
