using System;

namespace Substring
{
    class Program
    {
        static void Main()
        {
            string textToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            while (true)
            {
                if (!(text.Contains(textToRemove)))
                {
                    break;
                }
                int index = text.IndexOf(textToRemove);

                text = text.Remove(index, textToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}
