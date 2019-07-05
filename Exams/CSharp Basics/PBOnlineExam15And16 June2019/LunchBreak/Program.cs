using System;

namespace LunchBreak
{
    class Program
    {
        static void Main()
        {
            string serialName = Console.ReadLine();
            double serialLenght = double.Parse(Console.ReadLine());
            double restLenght = double.Parse(Console.ReadLine());

            double timeForLunch = restLenght * 1 / 8;
            double timeForRelax = restLenght * 1 / 4;
            double timeNeeded = restLenght - timeForLunch - timeForRelax;
            double timeLeft = Math.Abs(serialLenght - timeNeeded);


            if (timeNeeded>=serialLenght)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(timeLeft)} more minutes.");
            }
        }
    }
}
