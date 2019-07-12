using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] banWords = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();


            for (int i = 0; i < banWords.Length; i++)
            {
                text = text.Replace(banWords[i], new string('*', banWords[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
