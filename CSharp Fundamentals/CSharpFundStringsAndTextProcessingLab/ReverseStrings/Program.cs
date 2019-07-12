using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word=="end")
                {
                    break;
                }

                string reversed = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }

                Console.WriteLine($"{word} = {reversed}");
            }
        }
    }
}
