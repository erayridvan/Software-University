using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
