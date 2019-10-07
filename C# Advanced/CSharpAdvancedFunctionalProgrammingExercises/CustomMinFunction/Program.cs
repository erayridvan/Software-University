using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            Func<int[], int> minFunc = inputNumbers =>
            {
                int minValue = int.MaxValue;

                foreach (var currentNumber in inputNumbers)
                {
                    if (currentNumber<minValue)
                    {
                        minValue = currentNumber;
                    }
                }

                return minValue;
            };

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int minNumber = minFunc(numbers);

            Console.WriteLine(minNumber);
        }
    }
}
