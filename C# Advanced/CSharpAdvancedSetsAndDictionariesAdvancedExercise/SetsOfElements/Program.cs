using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsOfElements
{
    class Program
    {
        static void Main()
        {
            int[] setsLenght = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLenght = setsLenght[0];
            int secondSetLenght = setsLenght[1];

            int[] setOne = new int[firstSetLenght];
            for (int i = 0; i < firstSetLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                setOne[i] = currentNumber;
            }

            int[] setTwo = new int[secondSetLenght];
            for (int i = 0; i < secondSetLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                setTwo[i] = currentNumber;
            }

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < firstSetLenght; i++)
            {
                if (setTwo.Contains(setOne[i]))
                {
                    numbers.Add(setOne[i]);
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
