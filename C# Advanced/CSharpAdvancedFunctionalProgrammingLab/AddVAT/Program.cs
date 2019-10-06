using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();

            double[] numbersWithVat = numbers.Select(x => x * 1.20).ToArray();

            foreach (var number in numbersWithVat)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
