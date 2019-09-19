using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main()
        {
            var allChildren = Console.ReadLine().Split();
            Queue<string> childrens = new Queue<string>(allChildren);

            var number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (childrens.Count>1)
            {
                var currentChild = childrens.Dequeue();

                if (counter%number!=0)
                {
                    childrens.Enqueue(currentChild);
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                    counter = 1;
                }
            }

            Console.WriteLine($"Last is {childrens.Peek()}");
        }
    }
}
