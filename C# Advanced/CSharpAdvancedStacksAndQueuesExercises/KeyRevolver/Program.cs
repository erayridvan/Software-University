using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfTheBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int valueOfInteligence = int.Parse(Console.ReadLine());
            int bulletCounter = 0;

            while (true)
            {
                if (locks.Count == 0 || bullets.Count == 0)
                {
                    break;
                }

                int currentBullet = bullets.Peek();
                int currentLock = locks.Peek();

                bulletCounter++;

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();   
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                bullets.Pop();


                if (bulletCounter % sizeOfTheBarrel == 0 && bullets.Count!=0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            int earnedMoney = valueOfInteligence - (bulletCounter*priceOfBullet);

            if (locks.Count!=0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else 
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
        }
    }
}
