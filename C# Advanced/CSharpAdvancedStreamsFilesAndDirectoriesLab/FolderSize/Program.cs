using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("C:\\Users\\Eray\\Documents\\GitHub" +
                "\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\FolderSize\\06. Folder Size\\TestFolder");

            double totalLenght = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
               totalLenght += fileInfo.Length;
            }

            totalLenght = totalLenght / 1024 / 1024;

            Console.WriteLine(totalLenght);
        }
    }
}
