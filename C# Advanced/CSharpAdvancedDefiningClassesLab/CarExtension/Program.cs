using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            Car car = new Car();

            car.Make = "Audi";
            car.Model = "A4";
            car.Year = 2008;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
