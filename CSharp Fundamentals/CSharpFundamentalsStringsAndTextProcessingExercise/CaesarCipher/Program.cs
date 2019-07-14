using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            Encryption(text);

        }

        static void Encryption(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                result += (char)(currentSymbol + 3);
            }

            Console.WriteLine(result);
        }
    }
}
