using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var sum = SumOfDigits(firstNumber, secondNumber);
            var result = SubtractOfDigits(sum, thirdNumber);

            Console.WriteLine(result);
        }

        static int SumOfDigits(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int SubtractOfDigits(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }
    }
}
