using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("C:\\Users" +
                "\\Eray\\Documents\\Github\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\LineNumbers\\02. Line Numbers\\input.txt");

            var writer = new StreamWriter("output.txt");
            int counter = 1;
            using (reader)
            {
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
