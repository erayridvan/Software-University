using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            string result = "";

            if (firstSymbol>secondSymbol)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char currentSymbol = text[i];
                    if (currentSymbol<firstSymbol && currentSymbol>secondSymbol)
                    {
                        result += currentSymbol.ToString();
                    }
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char currentSymbol = text[i];
                    if (currentSymbol > firstSymbol && currentSymbol < secondSymbol)
                    {
                        result += currentSymbol.ToString();
                    }
                }
            }

            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                sum += (int)result[i];
            }

            Console.WriteLine(sum);
        }
    }
}
