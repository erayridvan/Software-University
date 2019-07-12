using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RepeatStrings
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var resultString = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int k = currentWord.Length - 1; k >= 0; k--)
                {
                    resultString.Append(currentWord);
                }
            }

            Console.WriteLine(resultString);
        }
    }
}
