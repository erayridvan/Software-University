using System;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            var result = Result(firstNumber, @operator, secondNumber);
            Console.WriteLine("{0}",result);
        }

        static double Result(double firstNumber , string @operator, double secondNumber)
        {
            double result = 0;
            switch (@operator)
            {
                case "+": result=firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/": result = firstNumber / secondNumber; break;
            }

            return Math.Round(result);
        }
    }
}
