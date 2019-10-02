using System;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("C:\\Users" +
                "\\Eray\\Documents\\Github\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\MergeFiles\\04. Merge Files\\FileOne.txt");

            var readerOne = new StreamReader("C:\\Users" +
                "\\Eray\\Documents\\Github\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\MergeFiles\\04. Merge Files\\FileTwo.txt");

            var writer = new StreamWriter("output.txt");

            using (reader)
            {
                using (readerOne)
                {
                    bool check = true;

                    while (check)
                    {
                        var firstLine = string.Empty;
                        var secondLine = string.Empty;

                        if ((firstLine= reader.ReadLine())!= null)
                        {
                            writer.WriteLine(firstLine);
                        }

                        if ((secondLine=readerOne.ReadLine())!=null)
                        {
                            writer.WriteLine(secondLine);
                        }

                        if (firstLine==null && secondLine==null)
                        {
                            check = false;
                        }
                    }
                    writer.Close();
                }
            }
        }
    }
}
