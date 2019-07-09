using System;

namespace Calculations
{
    class Program
    {
        static void Main()
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (operation=="add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (operation == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (operation == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (operation == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        static void Multiply(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        static void Subtract(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        static void Divide(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}
