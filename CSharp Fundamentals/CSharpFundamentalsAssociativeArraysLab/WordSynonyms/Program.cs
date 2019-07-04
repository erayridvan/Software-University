using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSynonyms
{
    class Program
    {
        static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            var dictSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < total; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if (!dictSynonyms.ContainsKey(word))
                {
                    dictSynonyms[word] = new List<string>();
                }
                dictSynonyms[word].Add(synonym);
            }

            foreach (var item in dictSynonyms)
            {
                var word = item.Key;
                var synonim = item.Value;
                Console.WriteLine($"{word} - {string.Join(", ",synonim)}");
            }
        }
    }
}
