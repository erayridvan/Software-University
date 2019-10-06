using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printToConsole = printNames;
            printToConsole(names);
        }

        private static void printNames(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}") ;
            }
        }
    }
}

