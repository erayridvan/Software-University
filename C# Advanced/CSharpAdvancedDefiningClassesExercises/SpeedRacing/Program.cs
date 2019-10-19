using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int index = int.Parse(Console.ReadLine());

            Car[] cars = new Car[index];

            for (int i = 0; i < index; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ");

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars[i] = car;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] info = command.Split(" ");

                string carModel = info[1];
                double amountOfKm = double.Parse(info[2]);

                cars.Where(x => x.Model == carModel).ToList().ForEach(x => x.Drive(amountOfKm));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.Model, car.FuelAmount, car.TravelledDistance);
            }
        }
    }
}
