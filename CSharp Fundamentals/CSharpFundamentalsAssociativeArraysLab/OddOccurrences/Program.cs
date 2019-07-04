using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .ToList();

            Dictionary<string, int> wordsNumberOfTimes = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string curruntWordInLowerCase = words[i].ToLower();
                if (!(wordsNumberOfTimes.ContainsKey(curruntWordInLowerCase)))
                {
                    wordsNumberOfTimes[curruntWordInLowerCase] =0;
                }
                wordsNumberOfTimes[curruntWordInLowerCase]++;
            }

            foreach (var word in wordsNumberOfTimes)
            {
                if (word.Value%2!=0)
                {
                    Console.Write($"{word.Key}"+ " ");
                }
            }
        }
    }
}
