using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main()
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            double lenghtOfStep = double.Parse(Console.ReadLine());
            double distanceToTravel = double.Parse(Console.ReadLine())*100;

            int fifthSteps = numberOfSteps / 5;
            double lenghtOfFifthStep =lenghtOfStep - (lenghtOfStep * 0.30);
            double totalDistance = 0;

            for (int i = 1; i <= numberOfSteps; i++)
            {
                if (i%5==0)
                {
                    totalDistance += lenghtOfFifthStep;
                }
                else
                {
                    totalDistance += lenghtOfStep;
                }
            }

            double procent = 100 * (totalDistance/distanceToTravel);

            Console.WriteLine($"You travelled {procent:f2}% of the distance!");
        }
    }
}
