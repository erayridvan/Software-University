using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            Func<int, int> addFunc = num => num += 1;
            Func<int, int> subtractFunc = num => num -= 1;
            Func<int, int> multiplyFunc = num => num *= 2;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ",nums));

            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers= numbers.Select(addFunc).ToList();
                }
                else if (command == "multiply")
                {
                    numbers=numbers.Select(multiplyFunc).ToList();
                }
                else if (command == "subtract")
                {
                    numbers= numbers.Select(subtractFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
