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
            car.FuelConsumption = 2;
            car.Drive(20);
            Console.WriteLine($"Make: { car.Make}\nModel: { car.Model}\nYear: { car.Year}\nFuel: { car.FuelQuantity:F2}L");
        }
    }
}
