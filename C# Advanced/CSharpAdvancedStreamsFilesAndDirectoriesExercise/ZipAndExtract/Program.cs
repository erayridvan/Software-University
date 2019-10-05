using System;
using System.IO.Compression;
using System.IO;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"../../ResultAfterUnzipped");
            Directory.CreateDirectory(@"ResultAfterZipped");
            DirectoryInfo di= new DirectoryInfo(Environment.CurrentDirectory+@"/new folder");
            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"/ResultAfterZipped/result.zip");
            DirectoryInfo dire = new DirectoryInfo(@"../../ResultAfterUnzipped");


            ZipFile.CreateFromDirectory(di.ToString(), dir.ToString());

            ZipFile.ExtractToDirectory(dir.ToString(), dire.ToString());
        }
    }
}
