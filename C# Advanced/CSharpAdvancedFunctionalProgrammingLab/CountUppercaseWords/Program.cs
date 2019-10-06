using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            var capitalWords = words.Where(word => char.IsUpper(word[0]));

            foreach (var word in capitalWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
