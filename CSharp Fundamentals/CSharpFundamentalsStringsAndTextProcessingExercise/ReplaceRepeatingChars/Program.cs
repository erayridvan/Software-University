using System;
using System.Linq;
using System.Collections.Generic;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char symbol = '0';

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (currentSymbol!=symbol)
                {
                    Console.Write(currentSymbol);
                }
                symbol = currentSymbol;
            }

            Console.WriteLine();

        }
    }
}
