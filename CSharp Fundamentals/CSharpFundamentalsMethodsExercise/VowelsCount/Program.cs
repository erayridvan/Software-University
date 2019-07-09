using System;

namespace VowelsCount
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();

            var count = VowelsCounter(text);

            Console.WriteLine(count);
        }

        static int VowelsCounter(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (currentLetter == 'a'
                    || currentLetter == 'e'
                    || currentLetter == 'i'
                    || currentLetter == 'o'
                    || currentLetter == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
