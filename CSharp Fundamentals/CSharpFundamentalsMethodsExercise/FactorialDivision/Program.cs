using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double result = FactorialCalculator(firstNumber) / FactorialCalculator(secondNumber);

            Console.WriteLine("{0:f2}",result);
        }

        static double FactorialCalculator (double number)
        {
            double result = 1;

            for (double i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
