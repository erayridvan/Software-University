using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main()
        {
            Queue<string> cars = new Queue<string>();
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            int passedCarCOunter = 0;
            
            string carName = string.Empty;

            while ((carName=Console.ReadLine()) != "END")
            {
                if (carName=="green")
                {
                    int leftseconds = greenLightSeconds;
                    while (leftseconds>0)
                    {
                        
                        if (cars.Count!=0)
                        {
                            string currentCar = cars.Peek();
                            if (currentCar.Length <= leftseconds)
                            {
                                leftseconds -= currentCar.Length;
                                passedCarCOunter++;
                                cars.Dequeue();
                            }
                            else
                            {
                                leftseconds += freeWindowSeconds;

                                if (leftseconds >= currentCar.Length)
                                {
                                    passedCarCOunter++;
                                    cars.Dequeue();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[leftseconds]}.");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                }
                else
                {
                    cars.Enqueue(carName);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCarCOunter} total cars passed the crossroads.");
        }
    }
}
