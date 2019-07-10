using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string arg = Console.ReadLine();

                if (arg=="END")
                {
                    break;
                }
                else
                {
                    int number = int.Parse(arg);
                    PalindromeChecker(number);
                }

            }
        }

        static void PalindromeChecker(int number)
        {
            int currentNumber = number;
            string resultNumber = "";

            while (currentNumber>0)
            {
                resultNumber += (currentNumber % 10).ToString();
                currentNumber /= 10;
            }

            int result = int.Parse(resultNumber);
            if (result==number)
            {
                Console.WriteLine(true.ToString().ToLower());
            }
            else
            {
                Console.WriteLine(false.ToString().ToLower());
            }
        }
    }
}
