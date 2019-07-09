using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            var result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int result = 0;

            while (true)
            {
                int currentDigit = number % 10;

                if (number==0)
                {
                    break;
                }
                else if (currentDigit%2==0)
                {
                    result += currentDigit;
                }
                number /= 10;
            }
            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            int result = 0;

            while (true)
            {
                int currentDigit = number % 10;
                if (number==0)
                {
                    break;
                }
                if (currentDigit % 2 != 0)
                {
                    result += currentDigit;
                }
                number /= 10;
            }
            return result;
        }

    }
}
