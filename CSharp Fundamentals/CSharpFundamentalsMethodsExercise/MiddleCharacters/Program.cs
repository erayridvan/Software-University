using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            FindMiddleChar(text);
        }

        static void FindMiddleChar(string text)
        {
            string result = string.Empty;

            if (text.Length%2==0)
            {
                result += text[text.Length / 2 - 1];
                result += text[text.Length / 2 ] ;
                Console.WriteLine(result);
            }
            else
            {
                result += text[text.Length/2];
                Console.WriteLine(result);
            }
        }
    }
}
