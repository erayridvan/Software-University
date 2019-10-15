using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main()
        {
            Func<int, List<int>, List<int>> myFunc = (bounder, deviders) =>
            {
                List<int> filterNumber = new List<int>();

                for (int i = 1; i <= bounder; i++)
                {
                    int currentNumber = i;

                    bool isDivisible = true;

                    for (int k = 0; k < deviders.Count; k++)
                    {
                        if (currentNumber%deviders[k]!=0)
                        {
                            isDivisible = false;
                        }
                    }

                    if (isDivisible)
                    {
                        filterNumber.Add(currentNumber);
                    }
                }
                return filterNumber;
            };

            int bouns = int.Parse(Console.ReadLine());

            List<int> divs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> numbers = new List<int>();

            numbers = myFunc(bouns,divs);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
