using STSdb4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.Workbench.Helpers
{
    public class FileImporter
    {
        public string FilePath { get; private set; }
        public FileType FileType { get; private set; }
        public char[] Delimiters { get; private set; }

        public FileImporter(string filePath, FileType fileType)
        {
            FilePath = filePath;
            FileType = fileType;

            Delimiters = SetDelimiters();
        }

        private char[] SetDelimiters()
        {
            List<char> delimiters = new List<char>();

            switch (FileType)
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

        public IEnumerable<KeyValuePair<object[], object[]>> Read(int keyLength, int recLength)
        {
            using (FileStream stream = new FileStream(FilePath, FileMode.Open))
            {
                StreamReader reader = new StreamReader(stream);
                while (!reader.EndOfStream)
                {
                    object[] key = new object[keyLength];
                    object[] rec = new object[recLength];

                    string line = reader.ReadLine();
                    var values = line.Split(Delimiters);

                    if (values.Length == keyLength + recLength)
                    {
                        for (int i = 0; i < keyLength; i++)
                            key[i] = values[i];

                        for (int i = keyLength; i < keyLength + recLength; i++)
                            rec[i - keyLength] = values[i];

                        yield return new KeyValuePair<object[], object[]>(key, rec);
                    }
                }
            }
        }
    }

    public enum FileType
    {
        Csv = 1,
        Epf = 2,
        TxtCommaSeparated = 3,
        TxtTabSeparated = 4,
    }
}
