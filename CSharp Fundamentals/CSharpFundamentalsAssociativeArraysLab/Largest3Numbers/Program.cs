using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            numbers = numbers.OrderByDescending(n => n).ToList();

            if (numbers.Count<3)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
