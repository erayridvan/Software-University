using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split("\\");
            string[] file = text[text.Length-1].Split(".").ToArray();

            string fileName = file[0];
            string fileExtension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
