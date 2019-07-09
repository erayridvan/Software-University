using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharsInGivenRange(firstChar, secondChar);
        }

        static void PrintCharsInGivenRange(char firstChar, char secondChar)
        {
            if (firstChar<secondChar)
            {
                for (int i = (int)firstChar + 1; i < (int)secondChar; i++)
                {
                    char currentChar = (char)(i);
                    Console.Write(currentChar + " ");
                }
            }
            else
            {
                for (int i = (int)secondChar + 1; i < (int)firstChar; i++)
                {
                    char currentChar = (char)(i);
                    Console.Write(currentChar + " ");
                }
            }
            
        }
    }
}
