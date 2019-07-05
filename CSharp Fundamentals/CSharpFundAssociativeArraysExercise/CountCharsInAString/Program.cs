using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .ToList();

            var occurrences = new Dictionary<char, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string curruntWord = words[i];
                for (int k = 0; k < curruntWord.Length; k++)
                {
                    char letter = curruntWord[k];

                    if (!(occurrences.ContainsKey(letter)))
                    {
                        occurrences[letter] = 0;
                    }
                    occurrences[letter]++;
                }
            }

            foreach (var letter in occurrences)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
