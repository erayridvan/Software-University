using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main()
        {
            Queue<string> cars = new Queue<string>();
            string currCar = string.Empty;
            int index = int.Parse(Console.ReadLine());
            int counter = 0;

            while ((currCar = Console.ReadLine()) != "end")
            {
                if (currCar=="green")
                {
                    if (index<=cars.Count)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            var currentCar = cars.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < cars.Count; i++)
                        {
                            var currentCar = cars.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                            counter++;
                            i = -1;
                        }
                    }
                   
                }
                else
                {
                    cars.Enqueue(currCar);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
