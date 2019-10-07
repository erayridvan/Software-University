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
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();

            int lowerBound = boundaries[0];
            int upperBound = boundaries[1];

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            Predicate<int> IsEvenPredicate = num => num % 2 == 0;

            if (command == "odd")
            {
                numbers.RemoveAll(IsEvenPredicate);
            }
            else if (command=="even")
            {
                numbers.RemoveAll(x=>!IsEvenPredicate(x));
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
