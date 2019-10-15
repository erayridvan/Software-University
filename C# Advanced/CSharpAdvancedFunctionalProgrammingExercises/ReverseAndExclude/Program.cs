using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>,int, List<int>> myFunc = (inputNumber, devider)=>
                 {
                     List<int> filterNumber = new List<int>();

                     foreach (var number in inputNumber)
                     {
                         if(number % devider != 0)
                         {
                             filterNumber.Add(number);
                         }
                     }

                     return filterNumber;
                 };


            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            numbers = myFunc(numbers, divider);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
