using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main()
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());


            Stack<int> clotherInBox = new Stack<int>(clothes);
            int rackCounter = 1;
            int currRackCapacity = rackCapacity;
            while (clotherInBox.Count>0)
            {
                int currentItem = clotherInBox.Peek();
                currRackCapacity -= currentItem;

                if (currRackCapacity >= 0)
                {
                    clotherInBox.Pop();
                }
                else
                {
                    rackCounter++;
                    currRackCapacity = rackCapacity;
                }
            }
            Console.WriteLine(rackCounter);
        }
    }
}
