using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main()
        {
            Func<string[], Func<string, int, bool>, int, string> myFunc = (names, isLargerFunc, totalSum)
                 => names.FirstOrDefault(x => isLargerFunc(x, totalSum));

            Func<string, int, bool> isEqualOrLargerFunc = (word, criteria) => word.Sum(x => x) >= criteria;

            int targetSum = int.Parse(Console.ReadLine());

            string[] inputNames = Console.ReadLine()
                .Split()
                .ToArray();

            

            string targetName = myFunc(inputNames, isEqualOrLargerFunc,targetSum);

            Console.WriteLine(targetName);
        }
    }
}
