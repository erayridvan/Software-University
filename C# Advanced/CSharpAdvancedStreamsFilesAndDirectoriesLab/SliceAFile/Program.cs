using System;
using System.IO;

namespace SliceAFile
{
    class Program
    {
        static void Main()
        {
            int parts = 4;

            var totalSize = new FileInfo("C:\\Users\\Eray\\Documents\\GitHub" +
                "\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\SliceAFile\\05. Slice File\\sliceMe.txt").Length;
            var sizePerFile = totalSize / 4;

            using(FileStream r = new FileStream("C:\\Users\\Eray\\Documents\\GitHub" +
                "\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\SliceAFile\\05. Slice File\\sliceMe.txt", FileMode.Open))
            {
                for (int i = 1; i <= parts; i++)
                {
                    var buffer = new byte[sizePerFile];
                    var readBytes = r.Read(buffer, 0, buffer.Length);

                    using (FileStream writer = new FileStream($"Part-{i}.txt", FileMode.OpenOrCreate))
                    {
                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
