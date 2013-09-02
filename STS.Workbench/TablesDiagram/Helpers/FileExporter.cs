using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Helpers
{
    public class FileExporter : IProgressable
    {
        private volatile bool ShutDown;

        public string FilePath { get; private set; }
        public string Delimiter { get; private set; }

        public int Percents { get; private set; }

        public FileExporter(string filePath)
        {
            FilePath = filePath;
            Delimiter = ";";

            ShutDown = false;
            Percents = 0;
        }

        public void Export(IEnumerable<KeyValuePair<object[], object[]>> data)
        {
            Export(data, data.Count());
        }

        public void Export(IEnumerable<KeyValuePair<object[], object[]>> data, long count)
        {
            ShutDown = false;
            Percents = 0;

            using (FileStream stream = new FileStream(FilePath, FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(stream);
                StringBuilder builder = new StringBuilder();
                int counter = 0;

                foreach (var kv in data)
                {
                    if (ShutDown)
                        break;

                    builder.Clear();
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

                    Percents = (int)((counter * 100) / count);
                    counter++;
                }

                writer.Flush();
                Percents = 0;
            }
        }

        public void Stop()
        {
            ShutDown = true;
        }
    }
}
