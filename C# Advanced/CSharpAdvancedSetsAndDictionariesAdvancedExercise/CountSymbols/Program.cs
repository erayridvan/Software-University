using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Dictionary<char, int> symbolCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                if (!symbolCount.ContainsKey(currentSymbol))
                {
                    symbolCount[currentSymbol] = 1;
                }
                else
                {
                    symbolCount[currentSymbol]++;
                }
            }

            foreach (var symbol in symbolCount.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
