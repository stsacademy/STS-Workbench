using STS.Workbench.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.TablesDiagram.Helpers
{
    public static class FileUtils
    {
        private static bool ShutDown;
        public static int Percents { get; private set; }

        static FileUtils()
        {
            ShutDown = false;
            Percents = 0;
        }

        public static void Stop()
        {
            ShutDown = true;
        }

        public static void Export(this IEnumerable<KeyValuePair<object[], object[]>> data, string filePath, FileType fileType)
        {
            data.Export(filePath, fileType, data.Count());
        }

        public static void Export(this IEnumerable<KeyValuePair<object[], object[]>> data, string filePath, FileType fileType, long count)
        {
            ShutDown = false;
            Percents = 0;
            string splitter = new string(SetDelimiters(fileType));

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
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
                        builder.Append(splitter);
                    }

                    foreach (var item in kv.Value)
                    {
                        builder.Append(item);
                        builder.Append(splitter);
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

        public static IEnumerable<KeyValuePair<object[], object[]>> Import(string fileName, FileType fileType, int keyLength, int recLength)
        {
            ShutDown = false;
            Percents = 0;
            char[] delimiters = SetDelimiters(fileType);

            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);
                long length = stream.Length;

                while (!ShutDown && !reader.EndOfStream)
                {
                    object[] key = new object[keyLength];
                    object[] rec = new object[recLength];

                    var values = reader.ReadLine().Split(delimiters);

                    if (values.Length == keyLength + recLength)
                    {
                        for (int i = 0; i < keyLength; i++)
                            key[i] = values[i];

                        for (int i = keyLength; i < keyLength + recLength; i++)
                            rec[i - keyLength] = values[i];

                        yield return new KeyValuePair<object[], object[]>(key, rec);
                    }

                    Percents = (int)((stream.Position * 100) / length);
                }

                Percents = 0;
            }
        }

        public static char[] SetDelimiters(FileType fileType)
        {
            List<char> delimiters = new List<char>();

            switch (fileType)
            {
                case FileType.Csv:
                    delimiters.Add(';');
                    break;
                case FileType.Epf:
                    delimiters.Add(',');
                    break;
                case FileType.TxtCommaSeparated:
                    delimiters.Add(',');
                    break;
                case FileType.TxtTabSeparated:
                    delimiters.Add(' ');
                    break;
                default:
                    delimiters.Add(' ');
                    break;
            }

            return delimiters.ToArray();
        }
    }

    public enum FileType
    {
        Csv = 1,
        Epf = 2,
        TxtCommaSeparated = 3,
        TxtTabSeparated = 4,
        Undefined = 100
    }
}
