using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            int[] boundaries = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int lowerBound = boundaries[0];
            int upperBound = boundaries[1];

            string command = Console.ReadLine();

            Predicate<int> odd = FindOdd;
            Predicate<int> Even = FindEven;

            List<int> numbers = new List<int>();
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (command == "odd")
                {
                    if (odd(i))
                    {
                        numbers.Add(i);
                    }
                }
                else if (command == "even")
                {
                    if (Even(i))
                    {
                        numbers.Add(i);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }

        private static bool FindOdd(int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            return false;
        }

        private static bool FindEven(int number)
        {
            if (number%2==0)
            {
                return true;
            }
            return false;
        }
    }
}
