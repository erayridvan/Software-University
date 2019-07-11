using System;
using System.Collections.Generic;

namespace TribonacciSequence
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number==1)
            {
                Console.WriteLine(number);
            }
            else if (number==2)
            {
                Console.WriteLine("1 1");
            }
            else if (number==3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                TribonacciSequence(number);
            }   
        }

        static void TribonacciSequence(int number)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int thirdNumber = 2;
            Console.Write($"{firstNumber} {secondNumber} {thirdNumber} ");

            for (int i = 0; i < number-3; i++)
            {
                int nextNumber = firstNumber + secondNumber + thirdNumber;
                Console.Write($"{nextNumber} ");

                firstNumber= secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = nextNumber;
            }
            Console.WriteLine();
        }
    }
}
