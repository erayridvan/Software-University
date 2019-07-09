using System;

namespace RepeatString
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(text, index);
            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string text, int index)
        {
            string result = string.Empty;
            for (int i = 0; i < index; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
