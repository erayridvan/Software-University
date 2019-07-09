using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "char")
            {
                char result = GetMaxChar();
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int result = GetMaxInt();
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
               string result= GetMaxString();
                Console.WriteLine(result);
            }
        }

        static char GetMaxChar()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar>secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMaxString()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            if (firstString.CompareTo(secondString)>=0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static int GetMaxInt()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber>secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
