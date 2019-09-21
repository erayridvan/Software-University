using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main()
        {
            Queue<int> cupsCapacity = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;

            while (true)
            {
                if (cupsCapacity.Count==0 || bottles.Count==0)
                {
                    break;
                }

                int currentCup = cupsCapacity.Peek();
                int currentBottle = bottles.Peek();

                if (currentBottle>=currentCup)
                {
                    wastedWater += (currentBottle-currentCup);
                    cupsCapacity.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    while (currentBottle<currentCup)
                    {
                        bottles.Pop();
                        currentBottle += bottles.Peek();
                    }

                    wastedWater += (currentBottle - currentCup);
                    cupsCapacity.Dequeue();
                    bottles.Pop();
                }
            }

            if (bottles.Count!=0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cupsCapacity)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            
        }
    }
}
